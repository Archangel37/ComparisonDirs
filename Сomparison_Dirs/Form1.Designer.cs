namespace Сomparison_Dirs
{
    partial class Main_Form
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_dir_A = new System.Windows.Forms.Button();
            this.btn_dir_B = new System.Windows.Forms.Button();
            this.Path_Dir_A = new System.Windows.Forms.TextBox();
            this.Path_Dir_B = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog_A = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_B = new System.Windows.Forms.FolderBrowserDialog();
            this.Evaluate_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_diffA_gage = new System.Windows.Forms.RichTextBox();
            this.textBox_diffB_gage = new System.Windows.Forms.RichTextBox();
            this.Common_Diff_Hash = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_dir_A
            // 
            this.btn_dir_A.Location = new System.Drawing.Point(59, 12);
            this.btn_dir_A.Name = "btn_dir_A";
            this.btn_dir_A.Size = new System.Drawing.Size(108, 37);
            this.btn_dir_A.TabIndex = 0;
            this.btn_dir_A.Text = "Browse Dir A";
            this.btn_dir_A.UseVisualStyleBackColor = true;
            this.btn_dir_A.Click += new System.EventHandler(this.btn_dir_A_Click);
            // 
            // btn_dir_B
            // 
            this.btn_dir_B.Location = new System.Drawing.Point(547, 12);
            this.btn_dir_B.Name = "btn_dir_B";
            this.btn_dir_B.Size = new System.Drawing.Size(108, 37);
            this.btn_dir_B.TabIndex = 0;
            this.btn_dir_B.Text = "Browse Dir B";
            this.btn_dir_B.UseVisualStyleBackColor = true;
            this.btn_dir_B.Click += new System.EventHandler(this.btn_dir_B_Click);
            // 
            // Path_Dir_A
            // 
            this.Path_Dir_A.Location = new System.Drawing.Point(59, 55);
            this.Path_Dir_A.Name = "Path_Dir_A";
            this.Path_Dir_A.Size = new System.Drawing.Size(366, 20);
            this.Path_Dir_A.TabIndex = 1;
            // 
            // Path_Dir_B
            // 
            this.Path_Dir_B.Location = new System.Drawing.Point(547, 55);
            this.Path_Dir_B.Name = "Path_Dir_B";
            this.Path_Dir_B.Size = new System.Drawing.Size(366, 20);
            this.Path_Dir_B.TabIndex = 1;
            // 
            // Evaluate_btn
            // 
            this.Evaluate_btn.Location = new System.Drawing.Point(12, 635);
            this.Evaluate_btn.Name = "Evaluate_btn";
            this.Evaluate_btn.Size = new System.Drawing.Size(75, 32);
            this.Evaluate_btn.TabIndex = 2;
            this.Evaluate_btn.Text = "GO!";
            this.Evaluate_btn.UseVisualStyleBackColor = true;
            this.Evaluate_btn.Click += new System.EventHandler(this.Evaluate_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Files From B, those no in A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Files From A, those no in B";
            // 
            // textBox_diffA_gage
            // 
            this.textBox_diffA_gage.Location = new System.Drawing.Point(62, 103);
            this.textBox_diffA_gage.Name = "textBox_diffA_gage";
            this.textBox_diffA_gage.Size = new System.Drawing.Size(363, 269);
            this.textBox_diffA_gage.TabIndex = 5;
            this.textBox_diffA_gage.Text = "";
            // 
            // textBox_diffB_gage
            // 
            this.textBox_diffB_gage.Location = new System.Drawing.Point(547, 103);
            this.textBox_diffB_gage.Name = "textBox_diffB_gage";
            this.textBox_diffB_gage.Size = new System.Drawing.Size(366, 269);
            this.textBox_diffB_gage.TabIndex = 5;
            this.textBox_diffB_gage.Text = "";
            // 
            // Common_Diff_Hash
            // 
            this.Common_Diff_Hash.Location = new System.Drawing.Point(111, 405);
            this.Common_Diff_Hash.Name = "Common_Diff_Hash";
            this.Common_Diff_Hash.Size = new System.Drawing.Size(802, 262);
            this.Common_Diff_Hash.TabIndex = 6;
            this.Common_Diff_Hash.Text = "";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 679);
            this.Controls.Add(this.Common_Diff_Hash);
            this.Controls.Add(this.textBox_diffB_gage);
            this.Controls.Add(this.textBox_diffA_gage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Evaluate_btn);
            this.Controls.Add(this.Path_Dir_B);
            this.Controls.Add(this.Path_Dir_A);
            this.Controls.Add(this.btn_dir_B);
            this.Controls.Add(this.btn_dir_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Comparison Directories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dir_A;
        private System.Windows.Forms.Button btn_dir_B;
        private System.Windows.Forms.TextBox Path_Dir_A;
        private System.Windows.Forms.TextBox Path_Dir_B;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_A;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_B;
        private System.Windows.Forms.Button Evaluate_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textBox_diffA_gage;
        private System.Windows.Forms.RichTextBox textBox_diffB_gage;
        private System.Windows.Forms.RichTextBox Common_Diff_Hash;
    }
}

