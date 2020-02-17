namespace Library_Automation
{
    partial class Form_Student_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Student_Update));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_add_amployee = new System.Windows.Forms.Panel();
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
            this.lab_level = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.lab_surname = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lab_search = new System.Windows.Forms.Label();
            this.txt_query = new System.Windows.Forms.TextBox();
            this.data_update = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel_add_amployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.panel_add_amployee);
            this.panel1.Controls.Add(this.lab_search);
            this.panel1.Controls.Add(this.txt_query);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 376);
            this.panel1.TabIndex = 1;
            // 
            // panel_add_amployee
            // 
            this.panel_add_amployee.Controls.Add(this.txt_phone);
            this.panel_add_amployee.Controls.Add(this.txt_tc);
            this.panel_add_amployee.Controls.Add(this.txt_password);
            this.panel_add_amployee.Controls.Add(this.sd);
            this.panel_add_amployee.Controls.Add(this.txt_address);
            this.panel_add_amployee.Controls.Add(this.text_address);
            this.panel_add_amployee.Controls.Add(this.text_phone);
            this.panel_add_amployee.Controls.Add(this.txt_email);
            this.panel_add_amployee.Controls.Add(this.text_email);
            this.panel_add_amployee.Controls.Add(this.asd);
            this.panel_add_amployee.Controls.Add(this.combo_level);
            this.panel_add_amployee.Controls.Add(this.lab_level);
            this.panel_add_amployee.Controls.Add(this.txt_surname);
            this.panel_add_amployee.Controls.Add(this.lab_surname);
            this.panel_add_amployee.Controls.Add(this.txt_name);
            this.panel_add_amployee.Controls.Add(this.lab_name);
            this.panel_add_amployee.Controls.Add(this.btn_delete);
            this.panel_add_amployee.Controls.Add(this.btn_update);
            this.panel_add_amployee.Location = new System.Drawing.Point(0, 62);
            this.panel_add_amployee.Name = "panel_add_amployee";
            this.panel_add_amployee.Size = new System.Drawing.Size(368, 314);
            this.panel_add_amployee.TabIndex = 5;
            // 
            // txt_phone
            // 
            this.txt_phone.HidePromptOnLeave = true;
            this.txt_phone.Location = new System.Drawing.Point(258, 115);
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
            this.txt_tc.Location = new System.Drawing.Point(79, 48);
            this.txt_tc.Mask = "00000000000";
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.PromptChar = ' ';
            this.txt_tc.Size = new System.Drawing.Size(100, 20);
            this.txt_tc.TabIndex = 0;
            this.txt_tc.ValidatingType = typeof(int);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(258, 83);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 5;
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Location = new System.Drawing.Point(186, 83);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(53, 13);
            this.sd.TabIndex = 35;
            this.sd.Text = "Password";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(258, 144);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 20);
            this.txt_address.TabIndex = 7;
            // 
            // text_address
            // 
            this.text_address.AutoSize = true;
            this.text_address.Location = new System.Drawing.Point(186, 147);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(46, 13);
            this.text_address.TabIndex = 33;
            this.text_address.Text = "Address";
            // 
            // text_phone
            // 
            this.text_phone.AutoSize = true;
            this.text_phone.Location = new System.Drawing.Point(186, 115);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(37, 13);
            this.text_phone.TabIndex = 32;
            this.text_phone.Text = "Phone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(258, 51);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 4;
            // 
            // text_email
            // 
            this.text_email.AutoSize = true;
            this.text_email.Location = new System.Drawing.Point(186, 51);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(31, 13);
            this.text_email.TabIndex = 30;
            this.text_email.Text = "Email";
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(7, 51);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(28, 13);
            this.asd.TabIndex = 29;
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
            this.combo_level.Location = new System.Drawing.Point(79, 148);
            this.combo_level.Name = "combo_level";
            this.combo_level.Size = new System.Drawing.Size(100, 21);
            this.combo_level.TabIndex = 3;
            // 
            // lab_level
            // 
            this.lab_level.AutoSize = true;
            this.lab_level.Location = new System.Drawing.Point(7, 148);
            this.lab_level.Name = "lab_level";
            this.lab_level.Size = new System.Drawing.Size(32, 13);
            this.lab_level.TabIndex = 27;
            this.lab_level.Text = "Level";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(79, 116);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(100, 20);
            this.txt_surname.TabIndex = 2;
            // 
            // lab_surname
            // 
            this.lab_surname.AutoSize = true;
            this.lab_surname.Location = new System.Drawing.Point(7, 116);
            this.lab_surname.Name = "lab_surname";
            this.lab_surname.Size = new System.Drawing.Size(49, 13);
            this.lab_surname.TabIndex = 25;
            this.lab_surname.Text = "Surname";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(79, 84);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(7, 84);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(34, 13);
            this.lab_name.TabIndex = 23;
            this.lab_name.Text = "Name";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(176, 218);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(88, 218);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lab_search
            // 
            this.lab_search.AutoSize = true;
            this.lab_search.Location = new System.Drawing.Point(105, 18);
            this.lab_search.Name = "lab_search";
            this.lab_search.Size = new System.Drawing.Size(40, 13);
            this.lab_search.TabIndex = 1;
            this.lab_search.Text = "Search";
            // 
            // txt_query
            // 
            this.txt_query.Location = new System.Drawing.Point(151, 15);
            this.txt_query.Name = "txt_query";
            this.txt_query.Size = new System.Drawing.Size(100, 20);
            this.txt_query.TabIndex = 0;
            this.txt_query.TextChanged += new System.EventHandler(this.txt_query_TextChanged);
            // 
            // data_update
            // 
            this.data_update.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.data_update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.data_update.Location = new System.Drawing.Point(376, 0);
            this.data_update.Name = "data_update";
            this.data_update.Size = new System.Drawing.Size(313, 379);
            this.data_update.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 376);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Form_Student_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(689, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.data_update);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Student_Update";
            this.Text = "Student Update";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_add_amployee.ResumeLayout(false);
            this.panel_add_amployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_search;
        private System.Windows.Forms.TextBox txt_query;
        private System.Windows.Forms.DataGridView data_update;
        private System.Windows.Forms.Panel panel_add_amployee;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox txt_phone;
        private System.Windows.Forms.MaskedTextBox txt_tc;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label text_address;
        private System.Windows.Forms.Label text_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label text_email;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.ComboBox combo_level;
        private System.Windows.Forms.Label lab_level;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lab_surname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lab_name;
    }
}