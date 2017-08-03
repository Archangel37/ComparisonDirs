using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Сomparison_Dirs
{
    public partial class Main_Form : Form
    {

        string Dir_A, Dir_B;
        string hash_temp;
        
        public Main_Form()
        {
            InitializeComponent();
            
        }

        private void btn_dir_A_Click(object sender, EventArgs e)
        {
            folderBrowserDialog_A.ShowDialog();
            if (folderBrowserDialog_A.SelectedPath != null)//обязательно условие на непустой вызов!
            {
                Path_Dir_A.Text = "";
                Path_Dir_A.Text = folderBrowserDialog_A.SelectedPath;
                Dir_A = folderBrowserDialog_A.SelectedPath;
            }
        }

        private void btn_dir_B_Click(object sender, EventArgs e)
        {
            folderBrowserDialog_B.ShowDialog();
            if (folderBrowserDialog_B.SelectedPath != null)
            {
                Path_Dir_B.Text = "";
                Path_Dir_B.Text = folderBrowserDialog_B.SelectedPath;
                Dir_B = folderBrowserDialog_B.SelectedPath;
            }
        }

        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static string GetHashCode(string PathFile)
        {
            string hash_temp_1;
            using (FileStream fs = System.IO.File.OpenRead(PathFile))
            {
                hash_temp_1 = "";
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                hash_temp_1 = result;
               
            }
            return hash_temp_1; 
        }
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

      //продумать, что будет с пустыми папками или с абсолютно одинаковыми файлами!!! пока прога ничего не делает в таком случае и не выводит ошибок


        private void Evaluate_btn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Dir_A) && !String.IsNullOrWhiteSpace(Dir_B))
            {
                var FilesA = Directory.EnumerateFiles(Dir_A).Select(Path.GetFileName);
                var FilesB = Directory.EnumerateFiles(Dir_B).Select(Path.GetFileName);
                var Diff_A_gage = FilesB.Except(FilesA);
                var Diff_B_gage = FilesA.Except(FilesB);

                int a = 0;

                foreach (string element in Diff_A_gage)
                {
                    hash_temp = GetHashCode(Dir_B + @"\" + element);//тут аккуратнее
                    a++;
                    textBox_diffA_gage.Text += a + ") " + element + Environment.NewLine;
                    textBox_diffA_gage.Text += "hash: " + hash_temp + Environment.NewLine + Environment.NewLine;
                }

                a = 0;
                foreach (string element in Diff_B_gage)
                {
                    hash_temp = GetHashCode(Dir_A + @"\" + element);//тут аккуратнее
                    a++;
                    textBox_diffB_gage.Text += a + ") " + element + Environment.NewLine;
                    textBox_diffB_gage.Text += "hash: " + hash_temp + Environment.NewLine + Environment.NewLine;
                }

                var CommonAB = FilesA.Intersect(FilesB);
                string hashA, hashB;
                int p = 0;

                foreach (string element in CommonAB)
                {
                    hashA = GetHashCode(Dir_A + @"\" + element);//тут аккуратнее A
                    hashB = GetHashCode(Dir_B + @"\" + element);//тут аккуратнее B
                    if (!String.Equals(hashA,hashB))
                    {
                    p++;
                    Common_Diff_Hash.Text += p + ") " + element + Environment.NewLine + " hash A: " + hashA + Environment.NewLine + " hash B: " + hashB + Environment.NewLine + Environment.NewLine;
                    }
                }


            }
        }
    }
}
