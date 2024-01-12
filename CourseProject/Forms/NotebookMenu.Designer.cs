namespace CourseProject.Forms
{
    partial class NotebookMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotebookMenu));
            this.NotebookGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.LastEditSortButton = new System.Windows.Forms.Button();
            this.AlfSortButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BirthdayGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.ASortH = new System.Windows.Forms.PictureBox();
            this.ASortL = new System.Windows.Forms.PictureBox();
            this.LEditSL = new System.Windows.Forms.PictureBox();
            this.LEditSH = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NoEntryLabel = new System.Windows.Forms.Label();
            this.NoSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NotebookGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASortH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASortL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEditSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEditSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NotebookGridView
            // 
            this.NotebookGridView.AllowUserToAddRows = false;
            this.NotebookGridView.AllowUserToDeleteRows = false;
            this.NotebookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotebookGridView.Location = new System.Drawing.Point(12, 137);
            this.NotebookGridView.Name = "NotebookGridView";
            this.NotebookGridView.ReadOnly = true;
            this.NotebookGridView.Size = new System.Drawing.Size(620, 381);
            this.NotebookGridView.TabIndex = 0;
            this.NotebookGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotebookGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Записная книжка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ваши записи:";
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateNewButton.Location = new System.Drawing.Point(638, 532);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(246, 43);
            this.CreateNewButton.TabIndex = 3;
            this.CreateNewButton.Text = "Создать новую запись";
            this.CreateNewButton.UseVisualStyleBackColor = true;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // LastEditSortButton
            // 
            this.LastEditSortButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastEditSortButton.Location = new System.Drawing.Point(281, 532);
            this.LastEditSortButton.Name = "LastEditSortButton";
            this.LastEditSortButton.Size = new System.Drawing.Size(300, 43);
            this.LastEditSortButton.TabIndex = 4;
            this.LastEditSortButton.Text = "Сортировать по последнему изменению";
            this.LastEditSortButton.UseVisualStyleBackColor = true;
            this.LastEditSortButton.Click += new System.EventHandler(this.LastEditSortButton_Click);
            // 
            // AlfSortButton
            // 
            this.AlfSortButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlfSortButton.Location = new System.Drawing.Point(12, 532);
            this.AlfSortButton.Name = "AlfSortButton";
            this.AlfSortButton.Size = new System.Drawing.Size(216, 43);
            this.AlfSortButton.TabIndex = 5;
            this.AlfSortButton.Text = "Сортировать по алфавиту";
            this.AlfSortButton.UseVisualStyleBackColor = true;
            this.AlfSortButton.Click += new System.EventHandler(this.AlfSortButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Что бы редактировать или удалить запись,  выберите её из таблицы";
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.Location = new System.Drawing.Point(419, 105);
            this.SearchBox.MaxLength = 50;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(213, 24);
            this.SearchBox.TabIndex = 7;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(358, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поиск:";
            // 
            // BirthdayGridView1
            // 
            this.BirthdayGridView1.AllowUserToAddRows = false;
            this.BirthdayGridView1.AllowUserToDeleteRows = false;
            this.BirthdayGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BirthdayGridView1.Location = new System.Drawing.Point(638, 137);
            this.BirthdayGridView1.Name = "BirthdayGridView1";
            this.BirthdayGridView1.ReadOnly = true;
            this.BirthdayGridView1.Size = new System.Drawing.Size(246, 381);
            this.BirthdayGridView1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(652, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Не забудьте поздравить";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(673, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "с днём рождения";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.BackColor = System.Drawing.Color.DarkGray;
            this.BirthdayLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayLabel.Location = new System.Drawing.Point(664, 315);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(196, 19);
            this.BirthdayLabel.TabIndex = 12;
            this.BirthdayLabel.Text = "Сегодня нет именинников";
            // 
            // ASortH
            // 
            this.ASortH.Image = ((System.Drawing.Image)(resources.GetObject("ASortH.Image")));
            this.ASortH.InitialImage = null;
            this.ASortH.Location = new System.Drawing.Point(235, 532);
            this.ASortH.Name = "ASortH";
            this.ASortH.Size = new System.Drawing.Size(40, 43);
            this.ASortH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ASortH.TabIndex = 13;
            this.ASortH.TabStop = false;
            // 
            // ASortL
            // 
            this.ASortL.Image = ((System.Drawing.Image)(resources.GetObject("ASortL.Image")));
            this.ASortL.InitialImage = null;
            this.ASortL.Location = new System.Drawing.Point(234, 532);
            this.ASortL.Name = "ASortL";
            this.ASortL.Size = new System.Drawing.Size(40, 43);
            this.ASortL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ASortL.TabIndex = 14;
            this.ASortL.TabStop = false;
            // 
            // LEditSL
            // 
            this.LEditSL.Image = ((System.Drawing.Image)(resources.GetObject("LEditSL.Image")));
            this.LEditSL.InitialImage = null;
            this.LEditSL.Location = new System.Drawing.Point(592, 532);
            this.LEditSL.Name = "LEditSL";
            this.LEditSL.Size = new System.Drawing.Size(40, 43);
            this.LEditSL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LEditSL.TabIndex = 15;
            this.LEditSL.TabStop = false;
            // 
            // LEditSH
            // 
            this.LEditSH.Image = ((System.Drawing.Image)(resources.GetObject("LEditSH.Image")));
            this.LEditSH.InitialImage = null;
            this.LEditSH.Location = new System.Drawing.Point(592, 532);
            this.LEditSH.Name = "LEditSH";
            this.LEditSH.Size = new System.Drawing.Size(40, 43);
            this.LEditSH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LEditSH.TabIndex = 16;
            this.LEditSH.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(834, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // NoEntryLabel
            // 
            this.NoEntryLabel.AutoSize = true;
            this.NoEntryLabel.BackColor = System.Drawing.Color.DarkGray;
            this.NoEntryLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoEntryLabel.Location = new System.Drawing.Point(244, 315);
            this.NoEntryLabel.Name = "NoEntryLabel";
            this.NoEntryLabel.Size = new System.Drawing.Size(171, 19);
            this.NoEntryLabel.TabIndex = 18;
            this.NoEntryLabel.Text = "У вас пока нет записей";
            this.NoEntryLabel.Visible = false;
            // 
            // NoSearch
            // 
            this.NoSearch.AutoSize = true;
            this.NoSearch.BackColor = System.Drawing.Color.DarkGray;
            this.NoSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoSearch.Location = new System.Drawing.Point(255, 296);
            this.NoSearch.Name = "NoSearch";
            this.NoSearch.Size = new System.Drawing.Size(147, 19);
            this.NoSearch.TabIndex = 19;
            this.NoSearch.Text = "Записи не найдены";
            this.NoSearch.Visible = false;
            // 
            // NotebookMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 604);
            this.Controls.Add(this.NoSearch);
            this.Controls.Add(this.NoEntryLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LEditSH);
            this.Controls.Add(this.LEditSL);
            this.Controls.Add(this.ASortL);
            this.Controls.Add(this.ASortH);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BirthdayGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AlfSortButton);
            this.Controls.Add(this.LastEditSortButton);
            this.Controls.Add(this.CreateNewButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotebookGridView);
            this.Name = "NotebookMenu";
            this.Text = "NotebookMenu";
            this.Load += new System.EventHandler(this.NotebookMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotebookGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASortH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASortL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEditSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEditSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NotebookGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.Button LastEditSortButton;
        private System.Windows.Forms.Button AlfSortButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView BirthdayGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.PictureBox ASortH;
        private System.Windows.Forms.PictureBox ASortL;
        private System.Windows.Forms.PictureBox LEditSL;
        private System.Windows.Forms.PictureBox LEditSH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NoEntryLabel;
        private System.Windows.Forms.Label NoSearch;
    }
}