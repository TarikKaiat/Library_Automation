namespace Library_Automation
{
    partial class Form_Employee_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Employee_Add));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_add_Book = new System.Windows.Forms.Panel();
            this.asd = new System.Windows.Forms.Label();
            this.text_start_date = new System.Windows.Forms.MaskedTextBox();
            this.text_salary = new System.Windows.Forms.MaskedTextBox();
            this.text_phone = new System.Windows.Forms.MaskedTextBox();
            this.text_tc = new System.Windows.Forms.MaskedTextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_surname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_add_Book.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_add_Book
            // 
            this.panel_add_Book.Controls.Add(this.asd);
            this.panel_add_Book.Controls.Add(this.text_start_date);
            this.panel_add_Book.Controls.Add(this.text_salary);
            this.panel_add_Book.Controls.Add(this.text_phone);
            this.panel_add_Book.Controls.Add(this.text_tc);
            this.panel_add_Book.Controls.Add(this.text_password);
            this.panel_add_Book.Controls.Add(this.label7);
            this.panel_add_Book.Controls.Add(this.text_surname);
            this.panel_add_Book.Controls.Add(this.label6);
            this.panel_add_Book.Controls.Add(this.text_address);
            this.panel_add_Book.Controls.Add(this.label5);
            this.panel_add_Book.Controls.Add(this.label4);
            this.panel_add_Book.Controls.Add(this.label1);
            this.panel_add_Book.Controls.Add(this.label2);
            this.panel_add_Book.Controls.Add(this.text_email);
            this.panel_add_Book.Controls.Add(this.label3);
            this.panel_add_Book.Controls.Add(this.btn_add);
            this.panel_add_Book.Controls.Add(this.text_name);
            this.panel_add_Book.Controls.Add(this.lab_name);
            this.panel_add_Book.Location = new System.Drawing.Point(3, 0);
            this.panel_add_Book.Name = "panel_add_Book";
            this.panel_add_Book.Size = new System.Drawing.Size(686, 367);
            this.panel_add_Book.TabIndex = 5;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(147, 207);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(57, 13);
            this.asd.TabIndex = 33;
            this.asd.Text = "Start Date";
            // 
            // text_start_date
            // 
            this.text_start_date.HidePromptOnLeave = true;
            this.text_start_date.Location = new System.Drawing.Point(235, 204);
            this.text_start_date.Mask = "00/00/0000";
            this.text_start_date.Name = "text_start_date";
            this.text_start_date.PromptChar = ' ';
            this.text_start_date.Size = new System.Drawing.Size(100, 20);
            this.text_start_date.TabIndex = 5;
            this.text_start_date.ValidatingType = typeof(System.DateTime);
            // 
            // text_salary
            // 
            this.text_salary.HidePromptOnLeave = true;
            this.text_salary.Location = new System.Drawing.Point(395, 58);
            this.text_salary.Mask = "00000";
            this.text_salary.Name = "text_salary";
            this.text_salary.PromptChar = ' ';
            this.text_salary.Size = new System.Drawing.Size(100, 20);
            this.text_salary.TabIndex = 6;
            this.text_salary.ValidatingType = typeof(int);
            // 
            // text_phone
            // 
            this.text_phone.HidePromptOnLeave = true;
            this.text_phone.Location = new System.Drawing.Point(235, 166);
            this.text_phone.Mask = "00000000000";
            this.text_phone.Name = "text_phone";
            this.text_phone.PromptChar = ' ';
            this.text_phone.Size = new System.Drawing.Size(100, 20);
            this.text_phone.TabIndex = 4;
            // 
            // text_tc
            // 
            this.text_tc.HidePromptOnLeave = true;
            this.text_tc.Location = new System.Drawing.Point(235, 55);
            this.text_tc.Mask = "00000000000";
            this.text_tc.Name = "text_tc";
            this.text_tc.PromptChar = ' ';
            this.text_tc.Size = new System.Drawing.Size(100, 20);
            this.text_tc.TabIndex = 1;
            this.text_tc.ValidatingType = typeof(int);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(395, 125);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(100, 20);
            this.text_password.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Password";
            // 
            // text_surname
            // 
            this.text_surname.Location = new System.Drawing.Point(235, 125);
            this.text_surname.Name = "text_surname";
            this.text_surname.Size = new System.Drawing.Size(100, 20);
            this.text_surname.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Surname";
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(395, 90);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(100, 20);
            this.text_address.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "T.C.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Phone Number";
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(395, 162);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(100, 20);
            this.text_email.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(235, 293);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(220, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "&Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(235, 90);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 20);
            this.text_name.TabIndex = 2;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(147, 90);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(34, 13);
            this.lab_name.TabIndex = 2;
            this.lab_name.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.panel_add_Book);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 381);
            this.panel1.TabIndex = 4;
            // 
            // Form_Employee_Add
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(689, 379);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Employee_Add";
            this.Text = "Employee";
            this.panel_add_Book.ResumeLayout(false);
            this.panel_add_Book.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel_add_Book;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.MaskedTextBox text_start_date;
        private System.Windows.Forms.MaskedTextBox text_salary;
        private System.Windows.Forms.MaskedTextBox text_phone;
        private System.Windows.Forms.MaskedTextBox text_tc;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_surname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Panel panel1;
    }
}