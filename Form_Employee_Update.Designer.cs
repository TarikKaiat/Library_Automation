namespace Library_Automation
{
    partial class Form_Employee_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Employee_Update));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_add_employee = new System.Windows.Forms.Panel();
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
            this.text_name = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lab_search = new System.Windows.Forms.Label();
            this.txt_query = new System.Windows.Forms.TextBox();
            this.data_update = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel_add_employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.panel_add_employee);
            this.panel1.Controls.Add(this.lab_search);
            this.panel1.Controls.Add(this.txt_query);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 379);
            this.panel1.TabIndex = 1;
            // 
            // panel_add_employee
            // 
            this.panel_add_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.panel_add_employee.Controls.Add(this.asd);
            this.panel_add_employee.Controls.Add(this.text_start_date);
            this.panel_add_employee.Controls.Add(this.text_salary);
            this.panel_add_employee.Controls.Add(this.text_phone);
            this.panel_add_employee.Controls.Add(this.text_tc);
            this.panel_add_employee.Controls.Add(this.text_password);
            this.panel_add_employee.Controls.Add(this.label7);
            this.panel_add_employee.Controls.Add(this.text_surname);
            this.panel_add_employee.Controls.Add(this.label6);
            this.panel_add_employee.Controls.Add(this.text_address);
            this.panel_add_employee.Controls.Add(this.label5);
            this.panel_add_employee.Controls.Add(this.label4);
            this.panel_add_employee.Controls.Add(this.label1);
            this.panel_add_employee.Controls.Add(this.label2);
            this.panel_add_employee.Controls.Add(this.text_email);
            this.panel_add_employee.Controls.Add(this.label3);
            this.panel_add_employee.Controls.Add(this.text_name);
            this.panel_add_employee.Controls.Add(this.lab_name);
            this.panel_add_employee.Controls.Add(this.btn_delete);
            this.panel_add_employee.Controls.Add(this.btn_update);
            this.panel_add_employee.Location = new System.Drawing.Point(0, 67);
            this.panel_add_employee.Name = "panel_add_employee";
            this.panel_add_employee.Size = new System.Drawing.Size(358, 309);
            this.panel_add_employee.TabIndex = 5;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(86, 192);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(57, 13);
            this.asd.TabIndex = 51;
            this.asd.Text = "Start Date";
            // 
            // text_start_date
            // 
            this.text_start_date.HidePromptOnLeave = true;
            this.text_start_date.Location = new System.Drawing.Point(174, 189);
            this.text_start_date.Mask = "00/00/0000";
            this.text_start_date.Name = "text_start_date";
            this.text_start_date.PromptChar = ' ';
            this.text_start_date.Size = new System.Drawing.Size(100, 20);
            this.text_start_date.TabIndex = 8;
            this.text_start_date.ValidatingType = typeof(System.DateTime);
            // 
            // text_salary
            // 
            this.text_salary.HidePromptOnLeave = true;
            this.text_salary.Location = new System.Drawing.Point(254, 37);
            this.text_salary.Mask = "00000";
            this.text_salary.Name = "text_salary";
            this.text_salary.PromptChar = ' ';
            this.text_salary.Size = new System.Drawing.Size(100, 20);
            this.text_salary.TabIndex = 4;
            this.text_salary.ValidatingType = typeof(int);
            // 
            // text_phone
            // 
            this.text_phone.HidePromptOnLeave = true;
            this.text_phone.Location = new System.Drawing.Point(94, 145);
            this.text_phone.Mask = "00000000000";
            this.text_phone.Name = "text_phone";
            this.text_phone.PromptChar = ' ';
            this.text_phone.Size = new System.Drawing.Size(100, 20);
            this.text_phone.TabIndex = 3;
            // 
            // text_tc
            // 
            this.text_tc.HidePromptOnLeave = true;
            this.text_tc.Location = new System.Drawing.Point(94, 34);
            this.text_tc.Mask = "00000000000";
            this.text_tc.Name = "text_tc";
            this.text_tc.PromptChar = ' ';
            this.text_tc.Size = new System.Drawing.Size(100, 20);
            this.text_tc.TabIndex = 0;
            this.text_tc.ValidatingType = typeof(int);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(254, 104);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(100, 20);
            this.text_password.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Password";
            // 
            // text_surname
            // 
            this.text_surname.Location = new System.Drawing.Point(94, 104);
            this.text_surname.Name = "text_surname";
            this.text_surname.Size = new System.Drawing.Size(100, 20);
            this.text_surname.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Surname";
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(254, 69);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(100, 20);
            this.text_address.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "T.C.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Phone Number";
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(254, 141);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(100, 20);
            this.text_email.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Email";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(94, 69);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 20);
            this.text_name.TabIndex = 1;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(6, 69);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(34, 13);
            this.lab_name.TabIndex = 34;
            this.lab_name.Text = "Name";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(218, 254);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(110, 254);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lab_search
            // 
            this.lab_search.AutoSize = true;
            this.lab_search.Location = new System.Drawing.Point(118, 25);
            this.lab_search.Name = "lab_search";
            this.lab_search.Size = new System.Drawing.Size(40, 13);
            this.lab_search.TabIndex = 1;
            this.lab_search.Text = "Search";
            // 
            // txt_query
            // 
            this.txt_query.Location = new System.Drawing.Point(164, 22);
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
            this.data_update.Location = new System.Drawing.Point(364, 0);
            this.data_update.Name = "data_update";
            this.data_update.Size = new System.Drawing.Size(325, 379);
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
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Form_Employee_Update
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
            this.Name = "Form_Employee_Update";
            this.Text = "Employee Update";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_add_employee.ResumeLayout(false);
            this.panel_add_employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_search;
        private System.Windows.Forms.TextBox txt_query;
        private System.Windows.Forms.Panel panel_add_employee;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
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
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.DataGridView data_update;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}