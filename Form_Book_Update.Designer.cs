namespace Library_Automation
{
    partial class Form_Book_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Book_Update));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_add_Book = new System.Windows.Forms.Panel();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_department = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lab_description = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.lab_department = new System.Windows.Forms.Label();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.lab_autor = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_search = new System.Windows.Forms.Label();
            this.txt_query = new System.Windows.Forms.TextBox();
            this.data_update = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel_add_Book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel_add_Book);
            this.panel1.Controls.Add(this.lab_search);
            this.panel1.Controls.Add(this.txt_query);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 379);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select The book you want to update from the list";
            // 
            // panel_add_Book
            // 
            this.panel_add_Book.Controls.Add(this.txt_count);
            this.panel_add_Book.Controls.Add(this.label2);
            this.panel_add_Book.Controls.Add(this.combo_department);
            this.panel_add_Book.Controls.Add(this.btn_delete);
            this.panel_add_Book.Controls.Add(this.txt_description);
            this.panel_add_Book.Controls.Add(this.lab_description);
            this.panel_add_Book.Controls.Add(this.btn_update);
            this.panel_add_Book.Controls.Add(this.lab_department);
            this.panel_add_Book.Controls.Add(this.txt_autor);
            this.panel_add_Book.Controls.Add(this.lab_autor);
            this.panel_add_Book.Controls.Add(this.txt_title);
            this.panel_add_Book.Controls.Add(this.lab_title);
            this.panel_add_Book.Location = new System.Drawing.Point(0, 113);
            this.panel_add_Book.Name = "panel_add_Book";
            this.panel_add_Book.Size = new System.Drawing.Size(363, 263);
            this.panel_add_Book.TabIndex = 1;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(151, 160);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(119, 20);
            this.txt_count.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Count";
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
            this.combo_department.Location = new System.Drawing.Point(149, 102);
            this.combo_department.Name = "combo_department";
            this.combo_department.Size = new System.Drawing.Size(121, 21);
            this.combo_department.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(176, 216);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(151, 134);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(119, 20);
            this.txt_description.TabIndex = 3;
            // 
            // lab_description
            // 
            this.lab_description.AutoSize = true;
            this.lab_description.Location = new System.Drawing.Point(79, 134);
            this.lab_description.Name = "lab_description";
            this.lab_description.Size = new System.Drawing.Size(60, 13);
            this.lab_description.TabIndex = 11;
            this.lab_description.Text = "Description";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(88, 216);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lab_department
            // 
            this.lab_department.AutoSize = true;
            this.lab_department.Location = new System.Drawing.Point(79, 102);
            this.lab_department.Name = "lab_department";
            this.lab_department.Size = new System.Drawing.Size(64, 13);
            this.lab_department.TabIndex = 6;
            this.lab_department.Text = "Department";
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(151, 70);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(119, 20);
            this.txt_autor.TabIndex = 1;
            // 
            // lab_autor
            // 
            this.lab_autor.AutoSize = true;
            this.lab_autor.Location = new System.Drawing.Point(79, 70);
            this.lab_autor.Name = "lab_autor";
            this.lab_autor.Size = new System.Drawing.Size(34, 13);
            this.lab_autor.TabIndex = 4;
            this.lab_autor.Text = "Autor";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(151, 38);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(119, 20);
            this.txt_title.TabIndex = 0;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Location = new System.Drawing.Point(79, 38);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(27, 13);
            this.lab_title.TabIndex = 2;
            this.lab_title.Text = "Title";
            // 
            // lab_search
            // 
            this.lab_search.AutoSize = true;
            this.lab_search.Location = new System.Drawing.Point(68, 22);
            this.lab_search.Name = "lab_search";
            this.lab_search.Size = new System.Drawing.Size(40, 13);
            this.lab_search.TabIndex = 0;
            this.lab_search.Text = "Search";
            // 
            // txt_query
            // 
            this.txt_query.Location = new System.Drawing.Point(114, 22);
            this.txt_query.Name = "txt_query";
            this.txt_query.Size = new System.Drawing.Size(172, 20);
            this.txt_query.TabIndex = 0;
            this.txt_query.TextChanged += new System.EventHandler(this.txt_query_TextChanged);
            // 
            // data_update
            // 
            this.data_update.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.data_update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.data_update.Location = new System.Drawing.Point(362, 0);
            this.data_update.Name = "data_update";
            this.data_update.Size = new System.Drawing.Size(327, 379);
            this.data_update.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(327, 379);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Form_Book_Update
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
            this.Name = "Form_Book_Update";
            this.Text = "Book Update";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_add_Book.ResumeLayout(false);
            this.panel_add_Book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_search;
        private System.Windows.Forms.TextBox txt_query;
        private System.Windows.Forms.DataGridView data_update;
        private System.Windows.Forms.Panel panel_add_Book;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lab_description;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lab_department;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label lab_autor;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label2;
    }
}