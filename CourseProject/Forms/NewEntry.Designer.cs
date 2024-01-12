namespace CourseProject.Forms
{
    partial class NewEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEntry));
            this.SaveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.QualityBox = new System.Windows.Forms.TextBox();
            this.PostBox = new System.Windows.Forms.TextBox();
            this.WorkPlaceBox = new System.Windows.Forms.TextBox();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.NatureBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.DateError = new System.Windows.Forms.PictureBox();
            this.PhoneError = new System.Windows.Forms.PictureBox();
            this.FIOPError = new System.Windows.Forms.PictureBox();
            this.Length1 = new System.Windows.Forms.Label();
            this.Length3 = new System.Windows.Forms.Label();
            this.Length5 = new System.Windows.Forms.Label();
            this.Length6 = new System.Windows.Forms.Label();
            this.Length7 = new System.Windows.Forms.Label();
            this.Length8 = new System.Windows.Forms.Label();
            this.Length9 = new System.Windows.Forms.Label();
            this.Length4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DateError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIOPError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(338, 552);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(245, 33);
            this.SaveButton.TabIndex = 92;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(86, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 33);
            this.button2.TabIndex = 91;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(81, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 26);
            this.label3.TabIndex = 90;
            this.label3.Text = "Создание новой записи";
            // 
            // NoteBox
            // 
            this.NoteBox.BackColor = System.Drawing.SystemColors.Control;
            this.NoteBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteBox.Location = new System.Drawing.Point(192, 480);
            this.NoteBox.MaxLength = 50;
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(392, 17);
            this.NoteBox.TabIndex = 88;
            this.NoteBox.TextChanged += new System.EventHandler(this.NoteBox_TextChanged);
            // 
            // QualityBox
            // 
            this.QualityBox.BackColor = System.Drawing.SystemColors.Control;
            this.QualityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QualityBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QualityBox.Location = new System.Drawing.Point(233, 432);
            this.QualityBox.MaxLength = 50;
            this.QualityBox.Name = "QualityBox";
            this.QualityBox.Size = new System.Drawing.Size(351, 17);
            this.QualityBox.TabIndex = 86;
            this.QualityBox.TextChanged += new System.EventHandler(this.QualityBox_TextChanged);
            // 
            // PostBox
            // 
            this.PostBox.BackColor = System.Drawing.SystemColors.Control;
            this.PostBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostBox.Location = new System.Drawing.Point(184, 336);
            this.PostBox.MaxLength = 50;
            this.PostBox.Name = "PostBox";
            this.PostBox.Size = new System.Drawing.Size(400, 17);
            this.PostBox.TabIndex = 82;
            this.PostBox.TextChanged += new System.EventHandler(this.PostBox_TextChanged);
            // 
            // WorkPlaceBox
            // 
            this.WorkPlaceBox.BackColor = System.Drawing.SystemColors.Control;
            this.WorkPlaceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkPlaceBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkPlaceBox.Location = new System.Drawing.Point(249, 288);
            this.WorkPlaceBox.MaxLength = 50;
            this.WorkPlaceBox.Name = "WorkPlaceBox";
            this.WorkPlaceBox.Size = new System.Drawing.Size(335, 17);
            this.WorkPlaceBox.TabIndex = 80;
            this.WorkPlaceBox.TextChanged += new System.EventHandler(this.WorkPlaceBox_TextChanged);
            // 
            // AdressBox
            // 
            this.AdressBox.BackColor = System.Drawing.SystemColors.Control;
            this.AdressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdressBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressBox.Location = new System.Drawing.Point(155, 202);
            this.AdressBox.MaxLength = 50;
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(429, 17);
            this.AdressBox.TabIndex = 76;
            this.AdressBox.TextChanged += new System.EventHandler(this.AdressBox_TextChanged);
            // 
            // FIOBox
            // 
            this.FIOBox.BackColor = System.Drawing.SystemColors.Control;
            this.FIOBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FIOBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOBox.Location = new System.Drawing.Point(230, 112);
            this.FIOBox.MaxLength = 50;
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(244, 17);
            this.FIOBox.TabIndex = 72;
            this.FIOBox.TextChanged += new System.EventHandler(this.FIOBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(82, 480);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 71;
            this.label12.Text = "Причечания:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(82, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 19);
            this.label11.TabIndex = 70;
            this.label11.Text = "Деловые качества:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(82, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 19);
            this.label10.TabIndex = 69;
            this.label10.Text = "Характер знакомства:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(82, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "Должность:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(82, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "Место работы/учёбы:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(82, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "Телефон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(82, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Адрес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(82, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = "Дата рождения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(82, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 63;
            this.label4.Text = "Имя/Псевдоним:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(226, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(357, 19);
            this.label13.TabIndex = 73;
            this.label13.Text = "__________________________________________________________";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(211, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(375, 19);
            this.label14.TabIndex = 75;
            this.label14.Text = "_____________________________________________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(151, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(435, 19);
            this.label15.TabIndex = 77;
            this.label15.Text = "_______________________________________________________________________";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(163, 246);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(423, 19);
            this.label16.TabIndex = 79;
            this.label16.Text = "_____________________________________________________________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(245, 288);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(339, 19);
            this.label17.TabIndex = 81;
            this.label17.Text = "_______________________________________________________";
            // 
            // NatureBox
            // 
            this.NatureBox.BackColor = System.Drawing.SystemColors.Control;
            this.NatureBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NatureBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NatureBox.Location = new System.Drawing.Point(251, 384);
            this.NatureBox.MaxLength = 50;
            this.NatureBox.Name = "NatureBox";
            this.NatureBox.Size = new System.Drawing.Size(333, 17);
            this.NatureBox.TabIndex = 84;
            this.NatureBox.TextChanged += new System.EventHandler(this.NatureBox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(229, 432);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(357, 19);
            this.label20.TabIndex = 87;
            this.label20.Text = "__________________________________________________________";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(188, 480);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(399, 19);
            this.label21.TabIndex = 89;
            this.label21.Text = "_________________________________________________________________";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(247, 384);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(339, 19);
            this.label19.TabIndex = 85;
            this.label19.Text = "_______________________________________________________";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(180, 336);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(405, 19);
            this.label18.TabIndex = 83;
            this.label18.Text = "__________________________________________________________________";
            // 
            // DateError
            // 
            this.DateError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DateError.BackgroundImage")));
            this.DateError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DateError.Location = new System.Drawing.Point(592, 143);
            this.DateError.Name = "DateError";
            this.DateError.Size = new System.Drawing.Size(38, 35);
            this.DateError.TabIndex = 93;
            this.DateError.TabStop = false;
            // 
            // PhoneError
            // 
            this.PhoneError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PhoneError.BackgroundImage")));
            this.PhoneError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PhoneError.Location = new System.Drawing.Point(592, 228);
            this.PhoneError.Name = "PhoneError";
            this.PhoneError.Size = new System.Drawing.Size(38, 35);
            this.PhoneError.TabIndex = 95;
            this.PhoneError.TabStop = false;
            // 
            // FIOPError
            // 
            this.FIOPError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FIOPError.BackgroundImage")));
            this.FIOPError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FIOPError.Location = new System.Drawing.Point(592, 96);
            this.FIOPError.Name = "FIOPError";
            this.FIOPError.Size = new System.Drawing.Size(38, 35);
            this.FIOPError.TabIndex = 101;
            this.FIOPError.TabStop = false;
            // 
            // Length1
            // 
            this.Length1.AutoSize = true;
            this.Length1.Location = new System.Drawing.Point(546, 96);
            this.Length1.Name = "Length1";
            this.Length1.Size = new System.Drawing.Size(30, 13);
            this.Length1.TabIndex = 102;
            this.Length1.Text = "0/50";
            // 
            // Length3
            // 
            this.Length3.AutoSize = true;
            this.Length3.Location = new System.Drawing.Point(546, 206);
            this.Length3.Name = "Length3";
            this.Length3.Size = new System.Drawing.Size(30, 13);
            this.Length3.TabIndex = 104;
            this.Length3.Text = "0/50";
            // 
            // Length5
            // 
            this.Length5.AutoSize = true;
            this.Length5.Location = new System.Drawing.Point(546, 292);
            this.Length5.Name = "Length5";
            this.Length5.Size = new System.Drawing.Size(30, 13);
            this.Length5.TabIndex = 106;
            this.Length5.Text = "0/50";
            // 
            // Length6
            // 
            this.Length6.AutoSize = true;
            this.Length6.Location = new System.Drawing.Point(546, 340);
            this.Length6.Name = "Length6";
            this.Length6.Size = new System.Drawing.Size(30, 13);
            this.Length6.TabIndex = 107;
            this.Length6.Text = "0/50";
            // 
            // Length7
            // 
            this.Length7.AutoSize = true;
            this.Length7.Location = new System.Drawing.Point(546, 388);
            this.Length7.Name = "Length7";
            this.Length7.Size = new System.Drawing.Size(30, 13);
            this.Length7.TabIndex = 108;
            this.Length7.Text = "0/50";
            // 
            // Length8
            // 
            this.Length8.AutoSize = true;
            this.Length8.Location = new System.Drawing.Point(546, 436);
            this.Length8.Name = "Length8";
            this.Length8.Size = new System.Drawing.Size(30, 13);
            this.Length8.TabIndex = 109;
            this.Length8.Text = "0/50";
            // 
            // Length9
            // 
            this.Length9.AutoSize = true;
            this.Length9.Location = new System.Drawing.Point(546, 484);
            this.Length9.Name = "Length9";
            this.Length9.Size = new System.Drawing.Size(30, 13);
            this.Length9.TabIndex = 110;
            this.Length9.Text = "0/50";
            // 
            // Length4
            // 
            this.Length4.AutoSize = true;
            this.Length4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Length4.Location = new System.Drawing.Point(169, 244);
            this.Length4.Name = "Length4";
            this.Length4.Size = new System.Drawing.Size(17, 19);
            this.Length4.TabIndex = 111;
            this.Length4.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Обязательное поле!";
            // 
            // PhoneBox
            // 
            this.PhoneBox.BackColor = System.Drawing.SystemColors.Control;
            this.PhoneBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneBox.Location = new System.Drawing.Point(184, 244);
            this.PhoneBox.Mask = "(999) 000-0000";
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(138, 17);
            this.PhoneBox.TabIndex = 113;
            this.PhoneBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Обязательное поле!";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(473, 112);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 13);
            this.label22.TabIndex = 115;
            this.label22.Text = "Обязательное поле!";
            // 
            // DateBox
            // 
            this.DateBox.BackColor = System.Drawing.SystemColors.Control;
            this.DateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBox.Location = new System.Drawing.Point(215, 159);
            this.DateBox.Mask = "00/00/0000";
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(252, 17);
            this.DateBox.TabIndex = 116;
            this.DateBox.ValidatingType = typeof(System.DateTime);
            this.DateBox.TextChanged += new System.EventHandler(this.DateBox_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(499, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            // 
            // NewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Length4);
            this.Controls.Add(this.Length9);
            this.Controls.Add(this.Length8);
            this.Controls.Add(this.Length7);
            this.Controls.Add(this.Length6);
            this.Controls.Add(this.Length5);
            this.Controls.Add(this.Length3);
            this.Controls.Add(this.Length1);
            this.Controls.Add(this.FIOPError);
            this.Controls.Add(this.PhoneError);
            this.Controls.Add(this.DateError);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.QualityBox);
            this.Controls.Add(this.PostBox);
            this.Controls.Add(this.WorkPlaceBox);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.NatureBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label14);
            this.Name = "NewEntry";
            this.Text = "NewEntry";
            this.Load += new System.EventHandler(this.NewEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DateError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIOPError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.TextBox QualityBox;
        private System.Windows.Forms.TextBox PostBox;
        private System.Windows.Forms.TextBox WorkPlaceBox;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox NatureBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox DateError;
        private System.Windows.Forms.PictureBox PhoneError;
        private System.Windows.Forms.PictureBox FIOPError;
        private System.Windows.Forms.Label Length1;
        private System.Windows.Forms.Label Length3;
        private System.Windows.Forms.Label Length5;
        private System.Windows.Forms.Label Length6;
        private System.Windows.Forms.Label Length7;
        private System.Windows.Forms.Label Length8;
        private System.Windows.Forms.Label Length9;
        private System.Windows.Forms.Label Length4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox PhoneBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox DateBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}