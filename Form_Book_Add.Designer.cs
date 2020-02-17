namespace Library_Automation
{
    partial class Form_Book_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Book_Add));
            this.panel_add_Book = new System.Windows.Forms.Panel();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_department = new System.Windows.Forms.ComboBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lab_description = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lab_department = new System.Windows.Forms.Label();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.lab_autor = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lab_title = new System.Windows.Forms.Label();
            this.panel_add_Book.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_add_Book
            // 
            this.panel_add_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.panel_add_Book.Controls.Add(this.txt_count);
            this.panel_add_Book.Controls.Add(this.label1);
            this.panel_add_Book.Controls.Add(this.combo_department);
            this.panel_add_Book.Controls.Add(this.txt_description);
            this.panel_add_Book.Controls.Add(this.lab_description);
            this.panel_add_Book.Controls.Add(this.btn_add);
            this.panel_add_Book.Controls.Add(this.lab_department);
            this.panel_add_Book.Controls.Add(this.txt_autor);
            this.panel_add_Book.Controls.Add(this.lab_autor);
            this.panel_add_Book.Controls.Add(this.txt_title);
            this.panel_add_Book.Controls.Add(this.lab_title);
            this.panel_add_Book.Location = new System.Drawing.Point(-1, -2);
            this.panel_add_Book.Name = "panel_add_Book";
            this.panel_add_Book.Size = new System.Drawing.Size(691, 382);
            this.panel_add_Book.TabIndex = 0;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(289, 213);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(100, 20);
            this.txt_count.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Count";
            // 
            // combo_department
            // 
            this.combo_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_department.FormattingEnabled = true;
            this.combo_department.Items.AddRange(new object[] {
            "Technology",
            "Literature",
            "Medicine",
            "Engineering",
            "Sciences",
            "Maths",
            "Divinity",
            "Education",
            "Sports"});
            this.combo_department.Location = new System.Drawing.Point(289, 144);
            this.combo_department.Name = "combo_department";
            this.combo_department.Size = new System.Drawing.Size(100, 21);
            this.combo_department.TabIndex = 3;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(289, 176);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(100, 20);
            this.txt_description.TabIndex = 4;
            // 
            // lab_description
            // 
            this.lab_description.AutoSize = true;
            this.lab_description.Location = new System.Drawing.Point(217, 176);
            this.lab_description.Name = "lab_description";
            this.lab_description.Size = new System.Drawing.Size(60, 13);
            this.lab_description.TabIndex = 11;
            this.lab_description.Text = "Description";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(289, 275);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lab_department
            // 
            this.lab_department.AutoSize = true;
            this.lab_department.Location = new System.Drawing.Point(217, 144);
            this.lab_department.Name = "lab_department";
            this.lab_department.Size = new System.Drawing.Size(64, 13);
            this.lab_department.TabIndex = 6;
            this.lab_department.Text = "Department";
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(289, 112);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(100, 20);
            this.txt_autor.TabIndex = 2;
            // 
            // lab_autor
            // 
            this.lab_autor.AutoSize = true;
            this.lab_autor.Location = new System.Drawing.Point(217, 112);
            this.lab_autor.Name = "lab_autor";
            this.lab_autor.Size = new System.Drawing.Size(34, 13);
            this.lab_autor.TabIndex = 4;
            this.lab_autor.Text = "Autor";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(289, 80);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(100, 20);
            this.txt_title.TabIndex = 1;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Location = new System.Drawing.Point(217, 80);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(27, 13);
            this.lab_title.TabIndex = 2;
            this.lab_title.Text = "Title";
            // 
            // Form_Book_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(689, 379);
            this.Controls.Add(this.panel_add_Book);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Book_Add";
            this.Text = " Add Book";
            this.Load += new System.EventHandler(this.Form_Book_Load);
            this.panel_add_Book.ResumeLayout(false);
            this.panel_add_Book.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_add_Book;
        private System.Windows.Forms.Label lab_department;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label lab_autor;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lab_description;
        private System.Windows.Forms.ComboBox combo_department;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label1;
    }
}