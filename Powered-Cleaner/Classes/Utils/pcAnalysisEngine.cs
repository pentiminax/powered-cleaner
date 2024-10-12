using Powered_Cleaner.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powered_Cleaner.Classes.Utils
{
    class pcAnalysisEngine
    {

        private static long analysisSize = 0;

        public static void GetFilesData(ref string[,] table, ref int index, ref long fileSize, FileInfo file)
        {
            try
            {
                table[index, 0] = file.FullName;
                table[index, 1] = (file.Length / 1024).ToString();
                fileSize += file.Length;
                if (file.Length <= 1000)
                    table[index, 1] = "1";
                index++;
            }
            catch (UnauthorizedAccessException) {}
            catch (IndexOutOfRangeException) {}
        }

        public static void FillData(DataGridView DtgData, string[,] table)
        {
            DtgData.Rows.Clear();
            int height = table.GetLength(0);
            int width = table.GetLength(1);
            DtgData.ColumnCount = width;
            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DtgData);
                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = table[r, c];
                }
                DtgData.Rows.Add(row);
            }
        }

        public static void ShowAnalysisSize(DataGridView DtgAnalyze, ref Label myLabel)
        {
            analysisSize = 0;
            for (int i = 0; i < DtgAnalyze.Rows.Count; i++)
            {
                try
                {
                    analysisSize += (long)DtgAnalyze.Rows[i].Cells[1].Value;
                }
                catch (Exception) { }
            }
            analysisSize /= 1024;
            StringBuilder stringBuilder = new StringBuilder(analysisSize + " " + strings.mbToRemove, 40);
            myLabel.ForeColor = Color.Red;
            myLabel.Show();
            myLabel.Text = stringBuilder.ToString();
            
        }

        public static long GetAnalysisSize(DataGridView DtgAnalyze)
        {
            return analysisSize;
        }

        public static string[,] ClearArrayNulls(ref string[,] input)
        {
            string[,] output = new string[0,0];
            try
            {
                int m = input.GetUpperBound(0);
                int n = input.GetUpperBound(1) + 1;
                string[] temp = new string[input.GetUpperBound(0)];
                for (int x = 0; x < m; x++)
                    temp[x] = input[x, 0];
                temp = temp.Where(s => !string.Equals(s, null)).ToArray();
                output = new string[temp.Length, n];
                Array.Copy(input, output, temp.Length * n);
            }
            catch (Exception){}
            return output;
        }

        public bool IsFileinUse(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }
    }
}