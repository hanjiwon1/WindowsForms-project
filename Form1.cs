using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 폴더 전체 복사 함수(하위폴더, 파일들 한번에)
        public void CopyFolder(string sourceFolder, string targetFolder) 
        {
            try
            {
                FileSystem.CopyDirectory(sourceFolder, targetFolder, UIOption.AllDialogs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //[.csv->.csv 파일 복사] 버튼 클릭하면 실행되는 함수
        private void btn_csv_to_csv_Click(object sender, EventArgs e)
        {
            //
            string str_source_Root;
            string str_target_Root;
            str_source_Root = this.textBox_source_csv.Text;
            str_target_Root = this.textBox_target_CsvToCsv.Text;

            CopyFolder(str_source_Root, str_target_Root);
            MessageBox.Show("작업 완료");

        }


        // dir_path 폴더에 있는 txt 파일 csv로 변환해주는 함수
        static void convert_txt_to_csv(string dir_path, string file_path)
        {
            string result = System.IO.Path.ChangeExtension(file_path, ".csv"); // "C:\Users\82109\Desktop\winform_test\CSVReader\source_csv\MS20N0016-17-1__20201202.csv"
            System.IO.File.Move(file_path, result); //"C: \Users\82109\Desktop\winform_test\CSVReader\source_csv\MS20N0016 - 17 - 1__20201202.txt"
        }

        // root폴더부터 하위 폴더들 모두 돌면서 txt파일 찾는 함수
        static void DirFileSearch(string dir_path, string extension)
        {
            try
            {
                //string str_file_path;
                string[] dirs = Directory.GetDirectories(dir_path);
                string[] files = Directory.GetFiles(dir_path, $"*.{extension}");
                
                foreach (string str_file_path in files)
                {
                    //str_file_path = f;
                    convert_txt_to_csv(dir_path, str_file_path);
                }

                if(dirs.Length > 0)
                {
                    foreach (string dir in dirs)
                    {
                        DirFileSearch(dir, "txt");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //[.txt->.csv 변환 후 복사] 버튼 클릭하면 실행되는 함수
        private void btn_txt_to_csv_Click(object sender, EventArgs e)
        {
            string str_source_Root;
            string str_target_Root;
            str_source_Root = this.textBox_source_txt.Text;
            str_target_Root = this.textBox_target_TxtToCsv.Text;

            // 복사 후 변환
            CopyFolder(str_source_Root, str_target_Root);

            DirFileSearch(str_target_Root, "txt");
            MessageBox.Show("복사 완료");
        }


        //아래 4개 함수 모두 다 [폴더 열기] 버튼 관련 함수
        private void folderOpenBnt_source_csv_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                textBox_source_csv.Text = fbd.SelectedPath;
            }
        }

        private void folderOpenBnt_target_csv_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox_target_CsvToCsv.Text = fbd.SelectedPath;
            }
            
        }

        private void folderOpenBnt_source_txt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = @"D:\source\";
            fbd.ShowDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox_source_txt.Text = fbd.SelectedPath;
            }
        }

        private void folderOpenBnt_target_txt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox_target_TxtToCsv.Text = fbd.SelectedPath;
            }
        }

    }
}
