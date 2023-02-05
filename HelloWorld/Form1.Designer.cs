namespace HelloWorld
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Input_textbox = new System.Windows.Forms.TextBox();
            this.radioBtn_MD5 = new System.Windows.Forms.RadioButton();
            this.radioBtn_SHA1 = new System.Windows.Forms.RadioButton();
            this.Browse_button = new System.Windows.Forms.Button();
            this.Result_textbox = new System.Windows.Forms.TextBox();
            this.radioBtn_SHA256 = new System.Windows.Forms.RadioButton();
            this.radioBtn_SHA512 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.Compare_Files_Btn = new System.Windows.Forms.Button();
            this.Compare_Result = new System.Windows.Forms.TextBox();
            this.Browse_F2_button = new System.Windows.Forms.Button();
            this.File2_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Browse_F1_button = new System.Windows.Forms.Button();
            this.File1_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.About = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CopyToClipboardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result:";
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Location = new System.Drawing.Point(260, 314);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(124, 23);
            this.Calculate_Button.TabIndex = 1;
            this.Calculate_Button.Text = "Calculate Hash";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Input_textbox
            // 
            this.Input_textbox.Location = new System.Drawing.Point(91, 60);
            this.Input_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Input_textbox.Name = "Input_textbox";
            this.Input_textbox.Size = new System.Drawing.Size(404, 20);
            this.Input_textbox.TabIndex = 2;
            // 
            // radioBtn_MD5
            // 
            this.radioBtn_MD5.AutoSize = true;
            this.radioBtn_MD5.Checked = true;
            this.radioBtn_MD5.Location = new System.Drawing.Point(226, 88);
            this.radioBtn_MD5.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtn_MD5.Name = "radioBtn_MD5";
            this.radioBtn_MD5.Size = new System.Drawing.Size(48, 17);
            this.radioBtn_MD5.TabIndex = 4;
            this.radioBtn_MD5.TabStop = true;
            this.radioBtn_MD5.Text = "MD5";
            this.radioBtn_MD5.UseVisualStyleBackColor = true;
            this.radioBtn_MD5.CheckedChanged += new System.EventHandler(this.radioBtn_MD5_CheckedChanged);
            // 
            // radioBtn_SHA1
            // 
            this.radioBtn_SHA1.AutoSize = true;
            this.radioBtn_SHA1.Location = new System.Drawing.Point(226, 112);
            this.radioBtn_SHA1.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtn_SHA1.Name = "radioBtn_SHA1";
            this.radioBtn_SHA1.Size = new System.Drawing.Size(53, 17);
            this.radioBtn_SHA1.TabIndex = 5;
            this.radioBtn_SHA1.Text = "SHA1";
            this.radioBtn_SHA1.UseVisualStyleBackColor = true;
            // 
            // Browse_button
            // 
            this.Browse_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Browse_button.Location = new System.Drawing.Point(542, 56);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(75, 23);
            this.Browse_button.TabIndex = 6;
            this.Browse_button.Text = "Browse";
            this.Browse_button.UseVisualStyleBackColor = true;
            this.Browse_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Result_textbox
            // 
            this.Result_textbox.Enabled = false;
            this.Result_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_textbox.Location = new System.Drawing.Point(142, 182);
            this.Result_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Result_textbox.Multiline = true;
            this.Result_textbox.Name = "Result_textbox";
            this.Result_textbox.Size = new System.Drawing.Size(354, 115);
            this.Result_textbox.TabIndex = 7;
            this.Result_textbox.TextChanged += new System.EventHandler(this.Result_textbox_TextChanged);
            // 
            // radioBtn_SHA256
            // 
            this.radioBtn_SHA256.AutoSize = true;
            this.radioBtn_SHA256.Location = new System.Drawing.Point(290, 88);
            this.radioBtn_SHA256.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtn_SHA256.Name = "radioBtn_SHA256";
            this.radioBtn_SHA256.Size = new System.Drawing.Size(65, 17);
            this.radioBtn_SHA256.TabIndex = 8;
            this.radioBtn_SHA256.Text = "SHA256";
            this.radioBtn_SHA256.UseVisualStyleBackColor = true;
            // 
            // radioBtn_SHA512
            // 
            this.radioBtn_SHA512.AutoSize = true;
            this.radioBtn_SHA512.Location = new System.Drawing.Point(290, 112);
            this.radioBtn_SHA512.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtn_SHA512.Name = "radioBtn_SHA512";
            this.radioBtn_SHA512.Size = new System.Drawing.Size(65, 17);
            this.radioBtn_SHA512.TabIndex = 10;
            this.radioBtn_SHA512.Text = "SHA512";
            this.radioBtn_SHA512.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 405);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CopyToClipboardButton);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.radioBtn_SHA512);
            this.tabPage1.Controls.Add(this.Browse_button);
            this.tabPage1.Controls.Add(this.radioBtn_SHA256);
            this.tabPage1.Controls.Add(this.Input_textbox);
            this.tabPage1.Controls.Add(this.radioBtn_SHA1);
            this.tabPage1.Controls.Add(this.Result_textbox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Calculate_Button);
            this.tabPage1.Controls.Add(this.radioBtn_MD5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(648, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "1. Choose File to perform check.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "2. Select Algorithm";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.Compare_Files_Btn);
            this.tabPage2.Controls.Add(this.Compare_Result);
            this.tabPage2.Controls.Add(this.Browse_F2_button);
            this.tabPage2.Controls.Add(this.File2_textBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Browse_F1_button);
            this.tabPage2.Controls.Add(this.File1_textBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(648, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compare";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Comparing large files may take some time ......";
            // 
            // Compare_Files_Btn
            // 
            this.Compare_Files_Btn.Location = new System.Drawing.Point(263, 317);
            this.Compare_Files_Btn.Name = "Compare_Files_Btn";
            this.Compare_Files_Btn.Size = new System.Drawing.Size(124, 23);
            this.Compare_Files_Btn.TabIndex = 25;
            this.Compare_Files_Btn.Text = "Compare Files";
            this.Compare_Files_Btn.UseVisualStyleBackColor = true;
            this.Compare_Files_Btn.Click += new System.EventHandler(this.Compare_Files_Btn_Click);
            // 
            // Compare_Result
            // 
            this.Compare_Result.Enabled = false;
            this.Compare_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compare_Result.Location = new System.Drawing.Point(152, 221);
            this.Compare_Result.Margin = new System.Windows.Forms.Padding(2);
            this.Compare_Result.Multiline = true;
            this.Compare_Result.Name = "Compare_Result";
            this.Compare_Result.Size = new System.Drawing.Size(354, 48);
            this.Compare_Result.TabIndex = 24;
            this.Compare_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Browse_F2_button
            // 
            this.Browse_F2_button.Location = new System.Drawing.Point(492, 128);
            this.Browse_F2_button.Name = "Browse_F2_button";
            this.Browse_F2_button.Size = new System.Drawing.Size(75, 23);
            this.Browse_F2_button.TabIndex = 18;
            this.Browse_F2_button.Text = "Browse";
            this.Browse_F2_button.UseVisualStyleBackColor = true;
            this.Browse_F2_button.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // File2_textBox
            // 
            this.File2_textBox.Location = new System.Drawing.Point(44, 135);
            this.File2_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.File2_textBox.Name = "File2_textBox";
            this.File2_textBox.Size = new System.Drawing.Size(404, 20);
            this.File2_textBox.TabIndex = 17;
            this.File2_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "2. Choose Second File to perform check.";
            // 
            // Browse_F1_button
            // 
            this.Browse_F1_button.Location = new System.Drawing.Point(492, 63);
            this.Browse_F1_button.Name = "Browse_F1_button";
            this.Browse_F1_button.Size = new System.Drawing.Size(75, 23);
            this.Browse_F1_button.TabIndex = 15;
            this.Browse_F1_button.Text = "Browse";
            this.Browse_F1_button.UseVisualStyleBackColor = true;
            this.Browse_F1_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // File1_textBox
            // 
            this.File1_textBox.Location = new System.Drawing.Point(44, 70);
            this.File1_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.File1_textBox.Name = "File1_textBox";
            this.File1_textBox.Size = new System.Drawing.Size(404, 20);
            this.File1_textBox.TabIndex = 14;
            this.File1_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "1. Choose First File to perform check.";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 416);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(652, 23);
            this.progressBar.TabIndex = 28;
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(614, 6);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(64, 27);
            this.About.TabIndex = 12;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hashing large files may take some time..";
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CopyToClipboardButton.Location = new System.Drawing.Point(513, 231);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(75, 23);
            this.CopyToClipboardButton.TabIndex = 14;
            this.CopyToClipboardButton.Text = "Copy";
            this.CopyToClipboardButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardButton.Click += new System.EventHandler(this.CopyButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 451);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.About);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hash Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculate_Button;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Input_textbox;
        private System.Windows.Forms.TextBox Result_textbox;
        private System.Windows.Forms.Button Browse_button;
        private System.Windows.Forms.RadioButton radioBtn_SHA1;
        private System.Windows.Forms.RadioButton radioBtn_MD5;
        private System.Windows.Forms.RadioButton radioBtn_SHA256;
        private System.Windows.Forms.RadioButton radioBtn_SHA512;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Browse_F2_button;
        private System.Windows.Forms.TextBox File2_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Browse_F1_button;
        private System.Windows.Forms.TextBox File1_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Compare_Files_Btn;
        private System.Windows.Forms.TextBox Compare_Result;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button CopyToClipboardButton;
        private System.Windows.Forms.Label label6;
    }
}

