namespace PassportRecognize
{
    partial class MainForm
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
            this.passportSerialTBox = new System.Windows.Forms.TextBox();
            this.SerialAndNumberLabel = new System.Windows.Forms.Label();
            this.passportNumberTbox = new System.Windows.Forms.TextBox();
            this.passportImagePicBx = new System.Windows.Forms.PictureBox();
            this.passportDataGBox = new System.Windows.Forms.GroupBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nationalComBx = new System.Windows.Forms.ComboBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeMTBx = new System.Windows.Forms.MaskedTextBox();
            this.genderCmbBx = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.passportGiveDateLabel = new System.Windows.Forms.Label();
            this.passportGiveDTP = new System.Windows.Forms.DateTimePicker();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.birdthDateDTP = new System.Windows.Forms.DateTimePicker();
            this.countyLabel = new System.Windows.Forms.Label();
            this.countryComboBx = new System.Windows.Forms.ComboBox();
            this.lastNameTxtBx = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.midlNameTxtBx = new System.Windows.Forms.TextBox();
            this.midlNameLabel = new System.Windows.Forms.Label();
            this.firstNameTBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccuracityLabel = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.BilletButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passportImagePicBx)).BeginInit();
            this.passportDataGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passportSerialTBox
            // 
            this.passportSerialTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passportSerialTBox.Location = new System.Drawing.Point(146, 157);
            this.passportSerialTBox.Name = "passportSerialTBox";
            this.passportSerialTBox.Size = new System.Drawing.Size(41, 20);
            this.passportSerialTBox.TabIndex = 0;
            // 
            // SerialAndNumberLabel
            // 
            this.SerialAndNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialAndNumberLabel.AutoSize = true;
            this.SerialAndNumberLabel.Location = new System.Drawing.Point(7, 160);
            this.SerialAndNumberLabel.Name = "SerialAndNumberLabel";
            this.SerialAndNumberLabel.Size = new System.Drawing.Size(133, 13);
            this.SerialAndNumberLabel.TabIndex = 1;
            this.SerialAndNumberLabel.Text = "Серия/Номер пасспорта";
            // 
            // passportNumberTbox
            // 
            this.passportNumberTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passportNumberTbox.Location = new System.Drawing.Point(193, 157);
            this.passportNumberTbox.Name = "passportNumberTbox";
            this.passportNumberTbox.Size = new System.Drawing.Size(97, 20);
            this.passportNumberTbox.TabIndex = 2;
            // 
            // passportImagePicBx
            // 
            this.passportImagePicBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passportImagePicBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passportImagePicBx.Location = new System.Drawing.Point(12, 20);
            this.passportImagePicBx.Name = "passportImagePicBx";
            this.passportImagePicBx.Size = new System.Drawing.Size(464, 418);
            this.passportImagePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passportImagePicBx.TabIndex = 3;
            this.passportImagePicBx.TabStop = false;
            // 
            // passportDataGBox
            // 
            this.passportDataGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passportDataGBox.Controls.Add(this.BilletButton);
            this.passportDataGBox.Controls.Add(this.checkBox);
            this.passportDataGBox.Controls.Add(this.acceptBtn);
            this.passportDataGBox.Controls.Add(this.label1);
            this.passportDataGBox.Controls.Add(this.nationalComBx);
            this.passportDataGBox.Controls.Add(this.codeLabel);
            this.passportDataGBox.Controls.Add(this.codeMTBx);
            this.passportDataGBox.Controls.Add(this.genderCmbBx);
            this.passportDataGBox.Controls.Add(this.genderLabel);
            this.passportDataGBox.Controls.Add(this.passportGiveDateLabel);
            this.passportDataGBox.Controls.Add(this.passportGiveDTP);
            this.passportDataGBox.Controls.Add(this.birthDateLabel);
            this.passportDataGBox.Controls.Add(this.birdthDateDTP);
            this.passportDataGBox.Controls.Add(this.countyLabel);
            this.passportDataGBox.Controls.Add(this.countryComboBx);
            this.passportDataGBox.Controls.Add(this.lastNameTxtBx);
            this.passportDataGBox.Controls.Add(this.lastNameLable);
            this.passportDataGBox.Controls.Add(this.midlNameTxtBx);
            this.passportDataGBox.Controls.Add(this.midlNameLabel);
            this.passportDataGBox.Controls.Add(this.firstNameTBox);
            this.passportDataGBox.Controls.Add(this.firstNameLabel);
            this.passportDataGBox.Controls.Add(this.passportSerialTBox);
            this.passportDataGBox.Controls.Add(this.passportNumberTbox);
            this.passportDataGBox.Controls.Add(this.SerialAndNumberLabel);
            this.passportDataGBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.passportDataGBox.Location = new System.Drawing.Point(482, 12);
            this.passportDataGBox.Name = "passportDataGBox";
            this.passportDataGBox.Size = new System.Drawing.Size(310, 426);
            this.passportDataGBox.TabIndex = 4;
            this.passportDataGBox.TabStop = false;
            // 
            // checkBox
            // 
            this.checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(68, 374);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(186, 17);
            this.checkBox.TabIndex = 23;
            this.checkBox.Text = "Я два раза проверил(а) данные";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptBtn.Enabled = false;
            this.acceptBtn.Location = new System.Drawing.Point(120, 397);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 21;
            this.acceptBtn.Text = "Подтвердить";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Национальность";
            // 
            // nationalComBx
            // 
            this.nationalComBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nationalComBx.FormattingEnabled = true;
            this.nationalComBx.Location = new System.Drawing.Point(104, 262);
            this.nationalComBx.Name = "nationalComBx";
            this.nationalComBx.Size = new System.Drawing.Size(185, 21);
            this.nationalComBx.TabIndex = 19;
            // 
            // codeLabel
            // 
            this.codeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(7, 239);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(107, 13);
            this.codeLabel.TabIndex = 18;
            this.codeLabel.Text = "Код подразделения";
            // 
            // codeMTBx
            // 
            this.codeMTBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeMTBx.Location = new System.Drawing.Point(120, 236);
            this.codeMTBx.Mask = "000-000";
            this.codeMTBx.Name = "codeMTBx";
            this.codeMTBx.Size = new System.Drawing.Size(170, 20);
            this.codeMTBx.TabIndex = 17;
            // 
            // genderCmbBx
            // 
            this.genderCmbBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genderCmbBx.FormattingEnabled = true;
            this.genderCmbBx.Location = new System.Drawing.Point(55, 130);
            this.genderCmbBx.Name = "genderCmbBx";
            this.genderCmbBx.Size = new System.Drawing.Size(234, 21);
            this.genderCmbBx.TabIndex = 16;
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(6, 133);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(43, 13);
            this.genderLabel.TabIndex = 15;
            this.genderLabel.Text = "Гендер";
            // 
            // passportGiveDateLabel
            // 
            this.passportGiveDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passportGiveDateLabel.AutoSize = true;
            this.passportGiveDateLabel.Location = new System.Drawing.Point(7, 189);
            this.passportGiveDateLabel.Name = "passportGiveDateLabel";
            this.passportGiveDateLabel.Size = new System.Drawing.Size(73, 13);
            this.passportGiveDateLabel.TabIndex = 14;
            this.passportGiveDateLabel.Text = "Дата выдачи";
            // 
            // passportGiveDTP
            // 
            this.passportGiveDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passportGiveDTP.Location = new System.Drawing.Point(86, 183);
            this.passportGiveDTP.Name = "passportGiveDTP";
            this.passportGiveDTP.Size = new System.Drawing.Size(204, 20);
            this.passportGiveDTP.TabIndex = 13;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(6, 110);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(86, 13);
            this.birthDateLabel.TabIndex = 12;
            this.birthDateLabel.Text = "Дата рождения";
            // 
            // birdthDateDTP
            // 
            this.birdthDateDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birdthDateDTP.Location = new System.Drawing.Point(98, 104);
            this.birdthDateDTP.Name = "birdthDateDTP";
            this.birdthDateDTP.Size = new System.Drawing.Size(191, 20);
            this.birdthDateDTP.TabIndex = 11;
            // 
            // countyLabel
            // 
            this.countyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countyLabel.AutoSize = true;
            this.countyLabel.Location = new System.Drawing.Point(7, 212);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(43, 13);
            this.countyLabel.TabIndex = 10;
            this.countyLabel.Text = "Страна";
            // 
            // countryComboBx
            // 
            this.countryComboBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryComboBx.FormattingEnabled = true;
            this.countryComboBx.Location = new System.Drawing.Point(56, 209);
            this.countryComboBx.Name = "countryComboBx";
            this.countryComboBx.Size = new System.Drawing.Size(234, 21);
            this.countryComboBx.TabIndex = 9;
            // 
            // lastNameTxtBx
            // 
            this.lastNameTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTxtBx.Location = new System.Drawing.Point(68, 78);
            this.lastNameTxtBx.Name = "lastNameTxtBx";
            this.lastNameTxtBx.Size = new System.Drawing.Size(221, 20);
            this.lastNameTxtBx.TabIndex = 8;
            // 
            // lastNameLable
            // 
            this.lastNameLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Location = new System.Drawing.Point(6, 81);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(54, 13);
            this.lastNameLable.TabIndex = 7;
            this.lastNameLable.Text = "Отчество";
            // 
            // midlNameTxtBx
            // 
            this.midlNameTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.midlNameTxtBx.Location = new System.Drawing.Point(68, 52);
            this.midlNameTxtBx.Name = "midlNameTxtBx";
            this.midlNameTxtBx.Size = new System.Drawing.Size(221, 20);
            this.midlNameTxtBx.TabIndex = 6;
            // 
            // midlNameLabel
            // 
            this.midlNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.midlNameLabel.AutoSize = true;
            this.midlNameLabel.Location = new System.Drawing.Point(6, 55);
            this.midlNameLabel.Name = "midlNameLabel";
            this.midlNameLabel.Size = new System.Drawing.Size(56, 13);
            this.midlNameLabel.TabIndex = 5;
            this.midlNameLabel.Text = "Фамилия";
            // 
            // firstNameTBox
            // 
            this.firstNameTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTBox.Location = new System.Drawing.Point(68, 26);
            this.firstNameTBox.Name = "firstNameTBox";
            this.firstNameTBox.Size = new System.Drawing.Size(221, 20);
            this.firstNameTBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 29);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "Имя";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Погрешность:";
            // 
            // AccuracityLabel
            // 
            this.AccuracityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccuracityLabel.AutoSize = true;
            this.AccuracityLabel.BackColor = System.Drawing.Color.Transparent;
            this.AccuracityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccuracityLabel.Location = new System.Drawing.Point(96, 20);
            this.AccuracityLabel.Name = "AccuracityLabel";
            this.AccuracityLabel.Size = new System.Drawing.Size(2, 15);
            this.AccuracityLabel.TabIndex = 22;
            // 
            // scanButton
            // 
            this.scanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanButton.BackColor = System.Drawing.Color.Transparent;
            this.scanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.scanButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.scanButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.scanButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scanButton.Location = new System.Drawing.Point(389, 20);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(87, 23);
            this.scanButton.TabIndex = 24;
            this.scanButton.Text = "Сканировать";
            this.scanButton.UseVisualStyleBackColor = false;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // BilletButton
            // 
            this.BilletButton.Enabled = false;
            this.BilletButton.Location = new System.Drawing.Point(201, 397);
            this.BilletButton.Name = "BilletButton";
            this.BilletButton.Size = new System.Drawing.Size(75, 23);
            this.BilletButton.TabIndex = 24;
            this.BilletButton.Text = "Билеты";
            this.BilletButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.AccuracityLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passportImagePicBx);
            this.Controls.Add(this.passportDataGBox);
            this.Name = "MainForm";
            this.Text = "Главная форма ";
            ((System.ComponentModel.ISupportInitialize)(this.passportImagePicBx)).EndInit();
            this.passportDataGBox.ResumeLayout(false);
            this.passportDataGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passportSerialTBox;
        private System.Windows.Forms.Label SerialAndNumberLabel;
        private System.Windows.Forms.TextBox passportNumberTbox;
        private System.Windows.Forms.PictureBox passportImagePicBx;
        private System.Windows.Forms.GroupBox passportDataGBox;
        private System.Windows.Forms.TextBox lastNameTxtBx;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.TextBox midlNameTxtBx;
        private System.Windows.Forms.Label midlNameLabel;
        private System.Windows.Forms.TextBox firstNameTBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.DateTimePicker birdthDateDTP;
        private System.Windows.Forms.Label passportGiveDateLabel;
        private System.Windows.Forms.DateTimePicker passportGiveDTP;
        private System.Windows.Forms.ComboBox genderCmbBx;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.MaskedTextBox codeMTBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nationalComBx;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AccuracityLabel;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Label countyLabel;
        private System.Windows.Forms.ComboBox countryComboBx;
        private System.Windows.Forms.Button BilletButton;
    }
}

