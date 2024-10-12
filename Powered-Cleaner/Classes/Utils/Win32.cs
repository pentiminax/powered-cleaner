using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularProgressBar;

namespace Powered_Cleaner
{
    public class Win32
    {
        #region Components
        public static string GetComponent(string hwclass, string syntax)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            try
            {
                foreach (ManagementObject mj in mos.Get())
                {
                    return (Convert.ToString(mj[syntax]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return null;
        }

        public static string ConvertBytesToGoString(long CapacityInBytes)
        {
            return Convert.ToString(CapacityInBytes / 1000000000);
        }
        #endregion

        #region Methods
        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void getDriveSpace(Label LblFreeSpace, Label LblTotalSize, CircularProgressBar.CircularProgressBar CpgbDisk)
        {
            DriveInfo dDrive = new DriveInfo("C");
            if (dDrive.IsReady)
            {
                double freeSpacePerc = Math.Round((dDrive.AvailableFreeSpace / (float)dDrive.TotalSize) * 100, 0);
                long freeSpace = dDrive.AvailableFreeSpace / 1073741824;
                long totalSize = dDrive.TotalSize / 1073741824;

                LblFreeSpace.Text = Convert.ToString(freeSpace) + " GB /";
                LblTotalSize.Text = Convert.ToString(totalSize) + " GB";
                long percentage = 100 - (freeSpace * 100 / totalSize);

                if (percentage > 50 && percentage < 80)
                    CpgbDisk.ProgressColor = Color.DarkOrange;
                else if (percentage > 80)
                    CpgbDisk.ProgressColor = Color.Red;
                else
                    CpgbDisk.ProgressColor = Color.Green;

                CpgbDisk.Text = Convert.ToString(percentage) + " %";
                CpgbDisk.Value = Convert.ToInt16((100 - (freeSpace * 100 / totalSize)));
                CpgbDisk.Update();
            }
        }
        #endregion

        public static string GetRAMsize()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject item in moc)
            {
                return Convert.ToString(Math.Round(Convert.ToDouble(item.Properties["TotalPhysicalMemory"].Value) / (1048576 * 1024), 0));
            }

            return "RAMsize";
        }

        #region Win32 Methods
        public static void LoadSystemInformations(List<string> liste)
        {
            string value = "";

            if (Environment.Is64BitOperatingSystem)
                value = "64 bits";
            else
                value = "32 bits";

            liste.Add(value); // OS TYPE 0
            value = GetComponent("Win32_Keyboard  ", "SystemName");
            liste.Add(value); // SYSTEM NAME 1
            value = GetComponent("Win32_Processor", "Name");
            liste.Add(value); // PROC NAME 2
            value = GetComponent("Win32_ComputerSystem", "Manufacturer");
            liste.Add(value); // MANUFACTURER 3
            value = GetComponent("Win32_DiskDrive", "Model");
            liste.Add(value); // DISK DRIVE 4
            value = GetComponent("Win32_BIOS", "Name");
            liste.Add(value); // BIOS NAME 5
            value = GetComponent("Win32_BaseBoard", "Product");
            liste.Add(value); // MODEL 6
            long Capacity = long.Parse(GetRAMsize());
            value = Capacity + " Go";
            liste.Add(value); // MEMORY 7
            value = GetComponent("Win32_SoundDevice", "Name");
            liste.Add(value); // AUDIO DEVICE 8
            value = GetComponent("Win32_VideoController", "Name");
            liste.Add(value); // VIDEO CONTROLLER 9
            value = GetComponent("Win32_OperatingSystem", "Caption");
            liste.Add(value); // OS VERSION 10
        }

        [DllImport("Shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);

        enum RecycleFlag : int
        {
            SHERB_NOCONFIRMATION = 0x00000001, // No confirmation, when emptying
            SHERB_NOPROGRESSUI = 0x00000001, // No progress tracking window during the emptying of the recycle bin
            SHERB_NOSOUND = 0x00000004 // No sound when the emptying of the recycle bin is complete
        }
        public static void EmptyRecycleBin()
        {
            SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlag.SHERB_NOSOUND | RecycleFlag.SHERB_NOCONFIRMATION);
        }
        #endregion
    }
}
