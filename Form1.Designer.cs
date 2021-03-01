
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_csv_to_csv = new System.Windows.Forms.Button();
            this.btn_txt_to_csv = new System.Windows.Forms.Button();
            this.textBox_target_CsvToCsv = new System.Windows.Forms.TextBox();
            this.textBox_source_txt = new System.Windows.Forms.TextBox();
            this.textBox_source_csv = new System.Windows.Forms.TextBox();
            this.textBox_target_TxtToCsv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.group_csv_to_csv = new System.Windows.Forms.Panel();
            this.folderOpenBnt_target_csv = new System.Windows.Forms.Button();
            this.folderOpenBnt_source_csv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.group_txt_to_csv = new System.Windows.Forms.Panel();
            this.folderOpenBnt_target_txt = new System.Windows.Forms.Button();
            this.folderOpenBnt_source_txt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.group_csv_to_csv.SuspendLayout();
            this.group_txt_to_csv.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_csv_to_csv
            // 
            this.btn_csv_to_csv.Location = new System.Drawing.Point(106, 260);
            this.btn_csv_to_csv.Name = "btn_csv_to_csv";
            this.btn_csv_to_csv.Size = new System.Drawing.Size(103, 76);
            this.btn_csv_to_csv.TabIndex = 0;
            this.btn_csv_to_csv.Text = ".csv -> .csv\r\n파일 복사";
            this.btn_csv_to_csv.UseVisualStyleBackColor = true;
            this.btn_csv_to_csv.Click += new System.EventHandler(this.btn_csv_to_csv_Click);
            // 
            // btn_txt_to_csv
            // 
            this.btn_txt_to_csv.Location = new System.Drawing.Point(114, 260);
            this.btn_txt_to_csv.Name = "btn_txt_to_csv";
            this.btn_txt_to_csv.Size = new System.Drawing.Size(103, 76);
            this.btn_txt_to_csv.TabIndex = 0;
            this.btn_txt_to_csv.Text = ".txt -> .csv\r\n변환 후 복사";
            this.btn_txt_to_csv.UseVisualStyleBackColor = true;
            this.btn_txt_to_csv.Click += new System.EventHandler(this.btn_txt_to_csv_Click);
            // 
            // textBox_target_CsvToCsv
            // 
            this.textBox_target_CsvToCsv.Location = new System.Drawing.Point(39, 162);
            this.textBox_target_CsvToCsv.Name = "textBox_target_CsvToCsv";
            this.textBox_target_CsvToCsv.Size = new System.Drawing.Size(234, 23);
            this.textBox_target_CsvToCsv.TabIndex = 1;
            // 
            // textBox_source_txt
            // 
            this.textBox_source_txt.Location = new System.Drawing.Point(42, 76);
            this.textBox_source_txt.Name = "textBox_source_txt";
            this.textBox_source_txt.Size = new System.Drawing.Size(234, 23);
            this.textBox_source_txt.TabIndex = 1;
            // 
            // textBox_source_csv
            // 
            this.textBox_source_csv.Location = new System.Drawing.Point(39, 76);
            this.textBox_source_csv.Name = "textBox_source_csv";
            this.textBox_source_csv.Size = new System.Drawing.Size(234, 23);
            this.textBox_source_csv.TabIndex = 2;
            // 
            // textBox_target_TxtToCsv
            // 
            this.textBox_target_TxtToCsv.Location = new System.Drawing.Point(42, 164);
            this.textBox_target_TxtToCsv.Name = "textBox_target_TxtToCsv";
            this.textBox_target_TxtToCsv.Size = new System.Drawing.Size(234, 23);
            this.textBox_target_TxtToCsv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target Root (.csv -> .csv)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "txt Source Root";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Target Root (.txt -> .csv)";
            // 
            // group_csv_to_csv
            // 
            this.group_csv_to_csv.BackColor = System.Drawing.SystemColors.Control;
            this.group_csv_to_csv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.group_csv_to_csv.Controls.Add(this.folderOpenBnt_target_csv);
            this.group_csv_to_csv.Controls.Add(this.folderOpenBnt_source_csv);
            this.group_csv_to_csv.Controls.Add(this.btn_csv_to_csv);
            this.group_csv_to_csv.Controls.Add(this.label2);
            this.group_csv_to_csv.Controls.Add(this.label1);
            this.group_csv_to_csv.Controls.Add(this.textBox_target_CsvToCsv);
            this.group_csv_to_csv.Controls.Add(this.textBox_source_csv);
            this.group_csv_to_csv.Location = new System.Drawing.Point(71, 47);
            this.group_csv_to_csv.Name = "group_csv_to_csv";
            this.group_csv_to_csv.Size = new System.Drawing.Size(317, 362);
            this.group_csv_to_csv.TabIndex = 7;
            // 
            // folderOpenBnt_target_csv
            // 
            this.folderOpenBnt_target_csv.Location = new System.Drawing.Point(198, 191);
            this.folderOpenBnt_target_csv.Name = "folderOpenBnt_target_csv";
            this.folderOpenBnt_target_csv.Size = new System.Drawing.Size(75, 23);
            this.folderOpenBnt_target_csv.TabIndex = 6;
            this.folderOpenBnt_target_csv.Text = "폴더변경";
            this.folderOpenBnt_target_csv.UseVisualStyleBackColor = true;
            this.folderOpenBnt_target_csv.Click += new System.EventHandler(this.folderOpenBnt_target_csv_Click);
            // 
            // folderOpenBnt_source_csv
            // 
            this.folderOpenBnt_source_csv.Location = new System.Drawing.Point(198, 105);
            this.folderOpenBnt_source_csv.Name = "folderOpenBnt_source_csv";
            this.folderOpenBnt_source_csv.Size = new System.Drawing.Size(75, 23);
            this.folderOpenBnt_source_csv.TabIndex = 5;
            this.folderOpenBnt_source_csv.Text = "폴더변경";
            this.folderOpenBnt_source_csv.UseVisualStyleBackColor = true;
            this.folderOpenBnt_source_csv.Click += new System.EventHandler(this.folderOpenBnt_source_csv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "csv Source Root";
            // 
            // group_txt_to_csv
            // 
            this.group_txt_to_csv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.group_txt_to_csv.Controls.Add(this.folderOpenBnt_target_txt);
            this.group_txt_to_csv.Controls.Add(this.folderOpenBnt_source_txt);
            this.group_txt_to_csv.Controls.Add(this.label4);
            this.group_txt_to_csv.Controls.Add(this.textBox_target_TxtToCsv);
            this.group_txt_to_csv.Controls.Add(this.label3);
            this.group_txt_to_csv.Controls.Add(this.btn_txt_to_csv);
            this.group_txt_to_csv.Controls.Add(this.textBox_source_txt);
            this.group_txt_to_csv.Location = new System.Drawing.Point(428, 47);
            this.group_txt_to_csv.Name = "group_txt_to_csv";
            this.group_txt_to_csv.Size = new System.Drawing.Size(317, 362);
            this.group_txt_to_csv.TabIndex = 8;
            // 
            // folderOpenBnt_target_txt
            // 
            this.folderOpenBnt_target_txt.Location = new System.Drawing.Point(201, 191);
            this.folderOpenBnt_target_txt.Name = "folderOpenBnt_target_txt";
            this.folderOpenBnt_target_txt.Size = new System.Drawing.Size(75, 23);
            this.folderOpenBnt_target_txt.TabIndex = 8;
            this.folderOpenBnt_target_txt.Text = "폴더변경";
            this.folderOpenBnt_target_txt.UseVisualStyleBackColor = true;
            this.folderOpenBnt_target_txt.Click += new System.EventHandler(this.folderOpenBnt_target_txt_Click);
            // 
            // folderOpenBnt_source_txt
            // 
            this.folderOpenBnt_source_txt.Location = new System.Drawing.Point(201, 105);
            this.folderOpenBnt_source_txt.Name = "folderOpenBnt_source_txt";
            this.folderOpenBnt_source_txt.Size = new System.Drawing.Size(75, 23);
            this.folderOpenBnt_source_txt.TabIndex = 7;
            this.folderOpenBnt_source_txt.Text = "폴더변경";
            this.folderOpenBnt_source_txt.UseVisualStyleBackColor = true;
            this.folderOpenBnt_source_txt.Click += new System.EventHandler(this.folderOpenBnt_source_txt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "txt to csv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "csv to csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.group_csv_to_csv);
            this.Controls.Add(this.group_txt_to_csv);
            this.Name = "Form1";
            this.Text = "Raw data 옮기기";
            this.group_csv_to_csv.ResumeLayout(false);
            this.group_csv_to_csv.PerformLayout();
            this.group_txt_to_csv.ResumeLayout(false);
            this.group_txt_to_csv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_csv_to_csv;
        private System.Windows.Forms.Button btn_txt_to_csv;
        private System.Windows.Forms.TextBox textBox_target_CsvToCsv;
        private System.Windows.Forms.TextBox textBox_source_txt;
        private System.Windows.Forms.TextBox textBox_source_csv;
        private System.Windows.Forms.TextBox textBox_target_TxtToCsv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel group_csv_to_csv;
        private System.Windows.Forms.Panel group_txt_to_csv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button folderOpenBnt_target_csv;
        private System.Windows.Forms.Button folderOpenBnt_source_csv;
        private System.Windows.Forms.Button folderOpenBnt_target_txt;
        private System.Windows.Forms.Button folderOpenBnt_source_txt;
        private System.Windows.Forms.Label label1;
    }
}

