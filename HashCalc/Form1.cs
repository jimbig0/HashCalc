﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = Input_textbox.Text;
            if (radioBtn_MD5.Checked == true)
            {
                // Calculate Hash using MD5 Algorithm
                Console.WriteLine("MD5 Selected");
                Console.WriteLine(ChecksumUtil.GetChecksum(HashingAlgoTypes.MD5, filepath));
                Result_textbox.Text = ChecksumUtil.GetChecksum(HashingAlgoTypes.MD5, filepath);
                return;
            }
            else if (radioBtn_SHA1.Checked == true)
            {
                // Calculate Hash using SHA1 Algorithm
                Console.WriteLine("SHA1 Selected");
                Console.WriteLine(ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA1, filepath));
                Result_textbox.Text = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA1, filepath);
                return;
            }
            else if (radioBtn_SHA256.Checked == true)
            {
                // Calculate Hash using SHA256 Algorithm
                Console.WriteLine("SHA256 Selected");
                Console.WriteLine(ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA256, filepath));
                Result_textbox.Text = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA256, filepath);
                return;
            }
            else if (radioBtn_SHA512.Checked == true)
            {
                Console.WriteLine("SHA512 Selected");
                Console.WriteLine(ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA512, filepath));
                Result_textbox.Text = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA512, filepath);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "any",
                Filter = "any files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Input_textbox.Text = openFileDialog1.FileName;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "any",
                Filter = "any files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File2_textBox.Text = openFileDialog1.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "any",
                Filter = "any files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File1_textBox.Text = openFileDialog1.FileName;
            }
        }

        private void Result_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioBtn_MD5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Compare_Files_Btn_Click(object sender, EventArgs e)
        {
            string firstfilepath = File1_textBox.Text;
            string secondfilepath = File2_textBox.Text;
            // Calculate First FileHash using MD5 Algorithm
            Console.WriteLine("MD5 Selected");
            string firstResult = ChecksumUtil.GetChecksum(HashingAlgoTypes.MD5, firstfilepath);
            Console.WriteLine(firstResult);
            // Calculate Second FileHash using MD5 Algorithm
            string secondResult = ChecksumUtil.GetChecksum(HashingAlgoTypes.MD5, secondfilepath);
            Console.WriteLine(secondResult);
            if (firstResult == secondResult)
            {
                Compare_Result.Text = "Files Match";
            }
            else if (firstResult!= secondResult) 
            {
                Compare_Result.Text = "No Match";
            }
            

        }
    }
}
public static class ChecksumUtil
{
    public static string GetChecksum(HashingAlgoTypes hashingAlgoType, string filename)
    {
        using (System.Security.Cryptography.HashAlgorithm hasher = System.Security.Cryptography.HashAlgorithm.Create(hashingAlgoType.ToString()))
        {
            using (System.IO.FileStream stream = System.IO.File.OpenRead(filename))
            {
                byte[] hash = hasher.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }
    }

}
public enum HashingAlgoTypes
{
    MD5,
    SHA1,
    SHA256,
    SHA384,
    SHA512
}