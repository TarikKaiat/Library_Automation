namespace Library_Automation
{
    partial class Form_Student_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Student_Add));
            this.panel_add_student = new System.Windows.Forms.Panel();
            this.txt_phone = new System.Windows.Forms.MaskedTextBox();
            this.txt_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.sd = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.text_address = new System.Windows.Forms.Label();
            this.text_phone = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.combo_level = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lab_level = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.lab_surname = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.panel_add_student.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_add_student
            // 
            this.panel_add_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.panel_add_student.Controls.Add(this.txt_phone);
            this.panel_add_student.Controls.Add(this.txt_tc);
            this.panel_add_student.Controls.Add(this.txt_password);
            this.panel_add_student.Controls.Add(this.sd);
            this.panel_add_student.Controls.Add(this.txt_address);
            this.panel_add_student.Controls.Add(this.text_address);
            this.panel_add_student.Controls.Add(this.text_phone);
            this.panel_add_student.Controls.Add(this.txt_email);
            this.panel_add_student.Controls.Add(this.text_email);
            this.panel_add_student.Controls.Add(this.asd);
            this.panel_add_student.Controls.Add(this.combo_level);
            this.panel_add_student.Controls.Add(this.btn_add);
            this.panel_add_student.Controls.Add(this.lab_level);
            this.panel_add_student.Controls.Add(this.txt_surname);
            this.panel_add_student.Controls.Add(this.lab_surname);
            this.panel_add_student.Controls.Add(this.txt_name);
            this.panel_add_student.Controls.Add(this.lab_name);
            this.panel_add_student.Location = new System.Drawing.Point(-1, 0);
            this.panel_add_student.Name = "panel_add_student";
            this.panel_add_student.Size = new System.Drawing.Size(689, 378);
            this.panel_add_student.TabIndex = 0;
            // 
            // txt_phone
            // 
            this.txt_phone.HidePromptOnLeave = true;
            this.txt_phone.Location = new System.Drawing.Point(392, 106);
            this.txt_phone.Mask = "00000000000";
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PromptChar = ' ';
            this.txt_phone.Size = new System.Drawing.Size(100, 20);
            this.txt_phone.TabIndex = 6;
            this.txt_phone.ValidatingType = typeof(int);
            // 
            // txt_tc
            // 
            this.txt_tc.HidePromptOnLeave = true;
            this.txt_tc.Location = new System.Drawing.Point(140, 38);
            this.txt_tc.Mask = "00000000000";
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.PromptChar = ' ';
            this.txt_tc.Size = new System.Drawing.Size(100, 20);
            this.txt_tc.TabIndex = 0;
            this.txt_tc.ValidatingType = typeof(int);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(392, 74);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 5;
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Location = new System.Drawing.Point(320, 74);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(53, 13);
            this.sd.TabIndex = 19;
            this.sd.Text = "Password";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(392, 135);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 20);
            this.txt_address.TabIndex = 7;
            // 
            // text_address
            // 
            this.text_address.AutoSize = true;
            this.text_address.Location = new System.Drawing.Point(320, 138);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(46, 13);
            this.text_address.TabIndex = 17;
            this.text_address.Text = "Address";
            // 
            // text_phone
            // 
            this.text_phone.AutoSize = true;
            this.text_phone.Location = new System.Drawing.Point(320, 106);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(37, 13);
            this.text_phone.TabIndex = 15;
            this.text_phone.Text = "Phone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(392, 42);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 4;
            // 
            // text_email
            // 
            this.text_email.AutoSize = true;
            this.text_email.Location = new System.Drawing.Point(320, 42);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(31, 13);
            this.text_email.TabIndex = 13;
            this.text_email.Text = "Email";
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(68, 41);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(28, 13);
            this.asd.TabIndex = 11;
            this.asd.Text = "T.C.";
            // 
            // combo_level
            // 
            this.combo_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_level.FormattingEnabled = true;
            this.combo_level.Items.AddRange(new object[] {
            "Associate Degree",
            "Bachelor\'s Degree",
            "Master\'s Degree",
            "Doctoral Degree"});
            this.combo_level.Location = new System.Drawing.Point(140, 138);
            this.combo_level.Name = "combo_level";
            this.combo_level.Size = new System.Drawing.Size(121, 21);
            this.combo_level.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(190, 210);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(244, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lab_level
            // 
            this.lab_level.AutoSize = true;
            this.lab_level.Location = new System.Drawing.Point(68, 138);
            this.lab_level.Name = "lab_level";
            this.lab_level.Size = new System.Drawing.Size(32, 13);
            this.lab_level.TabIndex = 6;
            this.lab_level.Text = "Level";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(140, 106);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(100, 20);
            this.txt_surname.TabIndex = 2;
            // 
            // lab_surname
            // 
            this.lab_surname.AutoSize = true;
            this.lab_surname.Location = new System.Drawing.Point(68, 106);
            this.lab_surname.Name = "lab_surname";
            this.lab_surname.Size = new System.Drawing.Size(49, 13);
            this.lab_surname.TabIndex = 4;
            this.lab_surname.Text = "Surname";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(140, 74);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(68, 74);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(34, 13);
            this.lab_name.TabIndex = 2;
            this.lab_name.Text = "Name";
            // 
            // Form_Student_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(689, 379);
            this.Controls.Add(this.panel_add_student);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Student_Add";
            this.Text = " Add Student";
            this.Load += new System.EventHandler(this.Form_Student_Load);
            this.panel_add_student.ResumeLayout(false);
            this.panel_add_student.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_add_student;
        private System.Windows.Forms.Label lab_level;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lab_surname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox combo_level;
        private System.Windows.Forms.Label text_address;
        private System.Windows.Forms.Label text_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label text_email;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.MaskedTextBox txt_tc;
        private System.Windows.Forms.MaskedTextBox txt_phone;
    }
}