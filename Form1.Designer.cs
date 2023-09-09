namespace SP_HW_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_SearchPattern = new System.Windows.Forms.TextBox();
            this.txtBox_SearchValue = new System.Windows.Forms.TextBox();
            this.cmbBox_LogDrives = new System.Windows.Forms.ComboBox();
            this.btn_SearchBeg = new System.Windows.Forms.Button();
            this.btn_SearchStop = new System.Windows.Forms.Button();
            this.chkBox_IncludeSubdirs = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colHead_FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead_Filepath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead_ModDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расширение файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Слово или фраза в файле";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Диски";
            // 
            // txtBox_SearchPattern
            // 
            this.txtBox_SearchPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_SearchPattern.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_SearchPattern.Location = new System.Drawing.Point(13, 26);
            this.txtBox_SearchPattern.Name = "txtBox_SearchPattern";
            this.txtBox_SearchPattern.Size = new System.Drawing.Size(150, 23);
            this.txtBox_SearchPattern.TabIndex = 3;
            // 
            // txtBox_SearchValue
            // 
            this.txtBox_SearchValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_SearchValue.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_SearchValue.Location = new System.Drawing.Point(169, 26);
            this.txtBox_SearchValue.Name = "txtBox_SearchValue";
            this.txtBox_SearchValue.Size = new System.Drawing.Size(236, 23);
            this.txtBox_SearchValue.TabIndex = 4;
            // 
            // cmbBox_LogDrives
            // 
            this.cmbBox_LogDrives.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBox_LogDrives.FormattingEnabled = true;
            this.cmbBox_LogDrives.Location = new System.Drawing.Point(411, 25);
            this.cmbBox_LogDrives.Name = "cmbBox_LogDrives";
            this.cmbBox_LogDrives.Size = new System.Drawing.Size(121, 25);
            this.cmbBox_LogDrives.TabIndex = 5;
            // 
            // btn_SearchBeg
            // 
            this.btn_SearchBeg.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SearchBeg.Location = new System.Drawing.Point(539, 25);
            this.btn_SearchBeg.Name = "btn_SearchBeg";
            this.btn_SearchBeg.Size = new System.Drawing.Size(75, 25);
            this.btn_SearchBeg.TabIndex = 6;
            this.btn_SearchBeg.Text = "Найти";
            this.btn_SearchBeg.UseVisualStyleBackColor = true;
            this.btn_SearchBeg.Click += new System.EventHandler(this.btn_SearchBeg_Click);
            // 
            // btn_SearchStop
            // 
            this.btn_SearchStop.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SearchStop.Location = new System.Drawing.Point(620, 26);
            this.btn_SearchStop.Name = "btn_SearchStop";
            this.btn_SearchStop.Size = new System.Drawing.Size(93, 25);
            this.btn_SearchStop.TabIndex = 7;
            this.btn_SearchStop.Text = "Остановить";
            this.btn_SearchStop.UseVisualStyleBackColor = true;
            this.btn_SearchStop.Click += new System.EventHandler(this.btn_SearchStop_Click);
            // 
            // chkBox_IncludeSubdirs
            // 
            this.chkBox_IncludeSubdirs.AutoSize = true;
            this.chkBox_IncludeSubdirs.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkBox_IncludeSubdirs.Location = new System.Drawing.Point(719, 29);
            this.chkBox_IncludeSubdirs.Name = "chkBox_IncludeSubdirs";
            this.chkBox_IncludeSubdirs.Size = new System.Drawing.Size(105, 21);
            this.chkBox_IncludeSubdirs.TabIndex = 8;
            this.chkBox_IncludeSubdirs.Text = "Подкаталоги";
            this.chkBox_IncludeSubdirs.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHead_FileName,
            this.colHead_Size,
            this.colHead_Filepath,
            this.colHead_ModDate});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(811, 382);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colHead_FileName
            // 
            this.colHead_FileName.Text = "Имя файла";
            this.colHead_FileName.Width = 149;
            // 
            // colHead_Size
            // 
            this.colHead_Size.Text = "Размер";
            this.colHead_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead_Size.Width = 104;
            // 
            // colHead_Filepath
            // 
            this.colHead_Filepath.Text = "Путь к файлу";
            this.colHead_Filepath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead_Filepath.Width = 347;
            // 
            // colHead_ModDate
            // 
            this.colHead_ModDate.Text = "Дата изменений";
            this.colHead_ModDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead_ModDate.Width = 106;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chkBox_IncludeSubdirs);
            this.Controls.Add(this.btn_SearchStop);
            this.Controls.Add(this.btn_SearchBeg);
            this.Controls.Add(this.cmbBox_LogDrives);
            this.Controls.Add(this.txtBox_SearchValue);
            this.Controls.Add(this.txtBox_SearchPattern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_SearchPattern;
        private System.Windows.Forms.TextBox txtBox_SearchValue;
        private System.Windows.Forms.ComboBox cmbBox_LogDrives;
        private System.Windows.Forms.Button btn_SearchBeg;
        private System.Windows.Forms.Button btn_SearchStop;
        private System.Windows.Forms.CheckBox chkBox_IncludeSubdirs;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colHead_FileName;
        private System.Windows.Forms.ColumnHeader colHead_Size;
        private System.Windows.Forms.ColumnHeader colHead_Filepath;
        private System.Windows.Forms.ColumnHeader colHead_ModDate;
    }
}

