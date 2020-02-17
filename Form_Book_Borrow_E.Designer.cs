namespace Library_Automation
{
    partial class Form_Book_Borrow_E
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Book_Borrow_E));
            this.panel_add_Book = new System.Windows.Forms.Panel();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_count_d = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_book_id = new System.Windows.Forms.TextBox();
            this.txt_stu_id = new System.Windows.Forms.TextBox();
            this.lab_student_id = new System.Windows.Forms.Label();
            this.lab_description_d = new System.Windows.Forms.Label();
            this.lab_department_d = new System.Windows.Forms.Label();
            this.lab_autor_d = new System.Windows.Forms.Label();
            this.lab_title_d = new System.Windows.Forms.Label();
            this.lab_description = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lab_department = new System.Windows.Forms.Label();
            this.lab_autor = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_id = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_add_Book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_add_Book
            // 
            this.panel_add_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.panel_add_Book.Controls.Add(this.btn_return);
            this.panel_add_Book.Controls.Add(this.btn_search);
            this.panel_add_Book.Controls.Add(this.lab_count_d);
            this.panel_add_Book.Controls.Add(this.label2);
            this.panel_add_Book.Controls.Add(this.txt_book_id);
            this.panel_add_Book.Controls.Add(this.txt_stu_id);
            this.panel_add_Book.Controls.Add(this.lab_student_id);
            this.panel_add_Book.Controls.Add(this.lab_description_d);
            this.panel_add_Book.Controls.Add(this.lab_department_d);
            this.panel_add_Book.Controls.Add(this.lab_autor_d);
            this.panel_add_Book.Controls.Add(this.lab_title_d);
            this.panel_add_Book.Controls.Add(this.lab_description);
            this.panel_add_Book.Controls.Add(this.btn_add);
            this.panel_add_Book.Controls.Add(this.lab_department);
            this.panel_add_Book.Controls.Add(this.lab_autor);
            this.panel_add_Book.Controls.Add(this.lab_title);
            this.panel_add_Book.Controls.Add(this.lab_id);
            this.panel_add_Book.Location = new System.Drawing.Point(-3, 1);
            this.panel_add_Book.Name = "panel_add_Book";
            this.panel_add_Book.Size = new System.Drawing.Size(381, 384);
            this.panel_add_Book.TabIndex = 0;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(228, 305);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(97, 23);
            this.btn_return.TabIndex = 6;
            this.btn_return.Text = "Return the book";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(250, 103);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(104, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search For Book";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lab_count_d
            // 
            this.lab_count_d.AutoSize = true;
            this.lab_count_d.Location = new System.Drawing.Point(151, 265);
            this.lab_count_d.Name = "lab_count_d";
            this.lab_count_d.Size = new System.Drawing.Size(0, 13);
            this.lab_count_d.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Count";
            // 
            // txt_book_id
            // 
            this.txt_book_id.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txt_book_id.ForeColor = System.Drawing.Color.Silver;
            this.txt_book_id.Location = new System.Drawing.Point(129, 105);
            this.txt_book_id.Name = "txt_book_id";
            this.txt_book_id.Size = new System.Drawing.Size(115, 20);
            this.txt_book_id.TabIndex = 4;
            this.txt_book_id.Tag = "";
            this.txt_book_id.Text = "Book Title or Auther";
            this.txt_book_id.Enter += new System.EventHandler(this.txt_book_id_Enter);
            this.txt_book_id.Leave += new System.EventHandler(this.txt_book_id_Leave);
            // 
            // txt_stu_id
            // 
            this.txt_stu_id.ForeColor = System.Drawing.Color.Silver;
            this.txt_stu_id.Location = new System.Drawing.Point(129, 73);
            this.txt_stu_id.Name = "txt_stu_id";
            this.txt_stu_id.Size = new System.Drawing.Size(225, 20);
            this.txt_stu_id.TabIndex = 3;
            this.txt_stu_id.Text = "T.C. , Name , Surname or Email";
            this.txt_stu_id.TextChanged += new System.EventHandler(this.txt_stu_id_TextChanged);
            this.txt_stu_id.Enter += new System.EventHandler(this.txt_stu_id_Enter);
            this.txt_stu_id.Leave += new System.EventHandler(this.txt_stu_id_Leave);
            // 
            // lab_student_id
            // 
            this.lab_student_id.AutoSize = true;
            this.lab_student_id.Location = new System.Drawing.Point(54, 76);
            this.lab_student_id.Name = "lab_student_id";
            this.lab_student_id.Size = new System.Drawing.Size(68, 13);
            this.lab_student_id.TabIndex = 10;
            this.lab_student_id.Text = "Student Info";
            // 
            // lab_description_d
            // 
            this.lab_description_d.AutoSize = true;
            this.lab_description_d.Location = new System.Drawing.Point(151, 233);
            this.lab_description_d.Name = "lab_description_d";
            this.lab_description_d.Size = new System.Drawing.Size(0, 13);
            this.lab_description_d.TabIndex = 1;
            // 
            // lab_department_d
            // 
            this.lab_department_d.AutoSize = true;
            this.lab_department_d.Location = new System.Drawing.Point(151, 201);
            this.lab_department_d.Name = "lab_department_d";
            this.lab_department_d.Size = new System.Drawing.Size(0, 13);
            this.lab_department_d.TabIndex = 14;
            // 
            // lab_autor_d
            // 
            this.lab_autor_d.AutoSize = true;
            this.lab_autor_d.Location = new System.Drawing.Point(151, 169);
            this.lab_autor_d.Name = "lab_autor_d";
            this.lab_autor_d.Size = new System.Drawing.Size(0, 13);
            this.lab_autor_d.TabIndex = 13;
            // 
            // lab_title_d
            // 
            this.lab_title_d.AutoSize = true;
            this.lab_title_d.Location = new System.Drawing.Point(151, 137);
            this.lab_title_d.Name = "lab_title_d";
            this.lab_title_d.Size = new System.Drawing.Size(0, 13);
            this.lab_title_d.TabIndex = 12;
            // 
            // lab_description
            // 
            this.lab_description.AutoSize = true;
            this.lab_description.Location = new System.Drawing.Point(54, 233);
            this.lab_description.Name = "lab_description";
            this.lab_description.Size = new System.Drawing.Size(60, 13);
            this.lab_description.TabIndex = 11;
            this.lab_description.Text = "Description";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(89, 305);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add the book";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lab_department
            // 
            this.lab_department.AutoSize = true;
            this.lab_department.Location = new System.Drawing.Point(54, 201);
            this.lab_department.Name = "lab_department";
            this.lab_department.Size = new System.Drawing.Size(64, 13);
            this.lab_department.TabIndex = 6;
            this.lab_department.Text = "Department";
            // 
            // lab_autor
            // 
            this.lab_autor.AutoSize = true;
            this.lab_autor.Location = new System.Drawing.Point(54, 169);
            this.lab_autor.Name = "lab_autor";
            this.lab_autor.Size = new System.Drawing.Size(34, 13);
            this.lab_autor.TabIndex = 4;
            this.lab_autor.Text = "Autor";
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Location = new System.Drawing.Point(54, 137);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(27, 13);
            this.lab_title.TabIndex = 2;
            this.lab_title.Text = "Title";
            // 
            // lab_id
            // 
            this.lab_id.AutoSize = true;
            this.lab_id.Location = new System.Drawing.Point(54, 105);
            this.lab_id.Name = "lab_id";
            this.lab_id.Size = new System.Drawing.Size(53, 13);
            this.lab_id.TabIndex = 0;
            this.lab_id.Text = "Book Info";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(314, 381);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form_Book_Borrow_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(689, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_add_Book);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Book_Borrow_E";
            this.Text = "Book Borrow";
            this.panel_add_Book.ResumeLayout(false);
            this.panel_add_Book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_add_Book;
        private System.Windows.Forms.Label lab_description_d;
        private System.Windows.Forms.Label lab_department_d;
        private System.Windows.Forms.Label lab_autor_d;
        private System.Windows.Forms.Label lab_title_d;
        private System.Windows.Forms.Label lab_description;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lab_department;
        private System.Windows.Forms.Label lab_autor;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_id;
        private System.Windows.Forms.Label lab_student_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_book_id;
        private System.Windows.Forms.TextBox txt_stu_id;
        private System.Windows.Forms.Label lab_count_d;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_return;
    }
}