namespace Library_Automation
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.leb_pass = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.leb_us = new System.Windows.Forms.Label();
            this.radio_stu = new System.Windows.Forms.RadioButton();
            this.radio_person = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.radio_stu);
            this.panel1.Controls.Add(this.radio_person);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.leb_pass);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.leb_us);
            this.panel1.Location = new System.Drawing.Point(64, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 216);
            this.panel1.TabIndex = 5;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(25, 95);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(168, 20);
            this.txt_username.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(71, 179);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login Panel";
            // 
            // leb_pass
            // 
            this.leb_pass.AutoSize = true;
            this.leb_pass.Location = new System.Drawing.Point(25, 124);
            this.leb_pass.Name = "leb_pass";
            this.leb_pass.Size = new System.Drawing.Size(53, 13);
            this.leb_pass.TabIndex = 8;
            this.leb_pass.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(25, 143);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(168, 20);
            this.txt_password.TabIndex = 3;
            // 
            // leb_us
            // 
            this.leb_us.AutoSize = true;
            this.leb_us.Location = new System.Drawing.Point(25, 79);
            this.leb_us.Name = "leb_us";
            this.leb_us.Size = new System.Drawing.Size(31, 13);
            this.leb_us.TabIndex = 6;
            this.leb_us.Text = "Email";
            // 
            // radio_stu
            // 
            this.radio_stu.AutoSize = true;
            this.radio_stu.Location = new System.Drawing.Point(121, 52);
            this.radio_stu.Name = "radio_stu";
            this.radio_stu.Size = new System.Drawing.Size(63, 17);
            this.radio_stu.TabIndex = 1;
            this.radio_stu.Text = "Student";
            this.radio_stu.UseVisualStyleBackColor = true;
            // 
            // radio_person
            // 
            this.radio_person.AutoSize = true;
            this.radio_person.Checked = true;
            this.radio_person.Location = new System.Drawing.Point(25, 52);
            this.radio_person.Name = "radio_person";
            this.radio_person.Size = new System.Drawing.Size(72, 17);
            this.radio_person.TabIndex = 0;
            this.radio_person.TabStop = true;
            this.radio_person.Text = "personnel";
            this.radio_person.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(120, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 128);
            this.panel2.TabIndex = 6;
            // 
            // Frm_login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(352, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label leb_pass;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label leb_us;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radio_stu;
        private System.Windows.Forms.RadioButton radio_person;
        private System.Windows.Forms.TextBox txt_username;
    }
}

