namespace Accounting_hotel_rooms_Windows
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Box_phone = new System.Windows.Forms.GroupBox();
            this.maskedphone = new System.Windows.Forms.MaskedTextBox();
            this.Box_email = new System.Windows.Forms.GroupBox();
            this.maskedemail = new System.Windows.Forms.MaskedTextBox();
            this.Type_nomer = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Box_name = new System.Windows.Forms.MaskedTextBox();
            this.Box_familya = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Box_phone.SuspendLayout();
            this.Box_email.SuspendLayout();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Регистрация по телефону ",
            "Онлаин регистрация "});
            this.Type.Location = new System.Drawing.Point(16, 47);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(372, 24);
            this.Type.TabIndex = 0;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите номер телефона ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите email";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите тип регистрации";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выбирите номер";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Выберите дату заселения";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Введите имя";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Введите фамилию";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // Box_phone
            // 
            this.Box_phone.Controls.Add(this.maskedphone);
            this.Box_phone.Controls.Add(this.label1);
            this.Box_phone.Location = new System.Drawing.Point(-1, 77);
            this.Box_phone.Name = "Box_phone";
            this.Box_phone.Size = new System.Drawing.Size(430, 72);
            this.Box_phone.TabIndex = 10;
            this.Box_phone.TabStop = false;
            // 
            // maskedphone
            // 
            this.maskedphone.AllowPromptAsInput = false;
            this.maskedphone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maskedphone.HidePromptOnLeave = true;
            this.maskedphone.Location = new System.Drawing.Point(17, 39);
            this.maskedphone.Mask = "8(000)000-00-00";
            this.maskedphone.Name = "maskedphone";
            this.maskedphone.Size = new System.Drawing.Size(372, 22);
            this.maskedphone.TabIndex = 2;
            this.maskedphone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedphone_MaskInputRejected_1);
            // 
            // Box_email
            // 
            this.Box_email.Controls.Add(this.maskedemail);
            this.Box_email.Controls.Add(this.label2);
            this.Box_email.Location = new System.Drawing.Point(-1, 155);
            this.Box_email.Name = "Box_email";
            this.Box_email.Size = new System.Drawing.Size(430, 76);
            this.Box_email.TabIndex = 11;
            this.Box_email.TabStop = false;
            // 
            // maskedemail
            // 
            this.maskedemail.Location = new System.Drawing.Point(17, 38);
            this.maskedemail.Name = "maskedemail";
            this.maskedemail.Size = new System.Drawing.Size(371, 22);
            this.maskedemail.TabIndex = 3;
            this.maskedemail.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Maskedemail_MaskInputRejected);
            // 
            // Type_nomer
            // 
            this.Type_nomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Type_nomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_nomer.FormattingEnabled = true;
            this.Type_nomer.Items.AddRange(new object[] {
            "Junior Suite (1000р)",
            "Family Room (1200р)",
            "Standart (1600р)",
            "President Villa (2500р)"});
            this.Type_nomer.Location = new System.Drawing.Point(16, 311);
            this.Type_nomer.Name = "Type_nomer";
            this.Type_nomer.Size = new System.Drawing.Size(372, 24);
            this.Type_nomer.TabIndex = 12;
            this.Type_nomer.SelectedIndexChanged += new System.EventHandler(this.Type_nomer_SelectedIndexChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(188, 414);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 30);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Button1_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(297, 414);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 30);
            this.save.TabIndex = 16;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Box_name
            // 
            this.Box_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_name.HidePromptOnLeave = true;
            this.Box_name.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.Box_name.Location = new System.Drawing.Point(15, 254);
            this.Box_name.Mask = ">L<???????????";
            this.Box_name.Name = "Box_name";
            this.Box_name.Size = new System.Drawing.Size(141, 22);
            this.Box_name.TabIndex = 17;
            this.Box_name.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Box_name_MaskInputRejected);
            // 
            // Box_familya
            // 
            this.Box_familya.HidePromptOnLeave = true;
            this.Box_familya.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.Box_familya.Location = new System.Drawing.Point(162, 254);
            this.Box_familya.Mask = ">L<?????????????????";
            this.Box_familya.Name = "Box_familya";
            this.Box_familya.Size = new System.Drawing.Size(226, 22);
            this.Box_familya.TabIndex = 18;
            this.Box_familya.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Box_familya_MaskInputRejected);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CausesValidation = false;
            this.dateTimePicker1.CustomFormat = "d MMMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 373);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(371, 22);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Add
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(409, 449);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Box_familya);
            this.Controls.Add(this.Box_name);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Type_nomer);
            this.Controls.Add(this.Box_email);
            this.Controls.Add(this.Box_phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма пегистрации";
            this.Load += new System.EventHandler(this.Add_Load);
            this.Box_phone.ResumeLayout(false);
            this.Box_phone.PerformLayout();
            this.Box_email.ResumeLayout(false);
            this.Box_email.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion





        ///тип регистрации
        private System.Windows.Forms.ComboBox Type;
        ///контейнер с телефоном и почтой 
        private System.Windows.Forms.GroupBox Box_phone;
        private System.Windows.Forms.GroupBox Box_email;
        ///сохранить / выход 
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;



        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.ComboBox Type_nomer;
        private System.Windows.Forms.MaskedTextBox maskedemail;
        private System.Windows.Forms.MaskedTextBox Box_name;
        private System.Windows.Forms.MaskedTextBox Box_familya;
        private System.Windows.Forms.MaskedTextBox maskedphone;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}