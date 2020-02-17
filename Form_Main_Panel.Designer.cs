namespace Library_Automation
{
    partial class Form_Main_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main_Panel));
            this.menu_panel = new System.Windows.Forms.MenuStrip();
            this.Menu_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Book_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Book_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Book_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Book_Borrow_s = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Student_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Student_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Student_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Employee_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Employee_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Employee_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help_View_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Book_Borrow_e = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Book,
            this.Menu_Student,
            this.Menu_Employee,
            this.Menu_Help});
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(712, 24);
            this.menu_panel.TabIndex = 0;
            this.menu_panel.Text = "menuStrip1";
            // 
            // Menu_Book
            // 
            this.Menu_Book.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Book_Add,
            this.Menu_Book_Search,
            this.Menu_Book_Update,
            this.Menu_Book_Borrow_e,
            this.Menu_Book_Borrow_s});
            this.Menu_Book.Name = "Menu_Book";
            this.Menu_Book.Size = new System.Drawing.Size(46, 20);
            this.Menu_Book.Text = "&Book";
            // 
            // Menu_Book_Add
            // 
            this.Menu_Book_Add.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Book_Add.Image")));
            this.Menu_Book_Add.Name = "Menu_Book_Add";
            this.Menu_Book_Add.Size = new System.Drawing.Size(180, 22);
            this.Menu_Book_Add.Text = "&Add";
            this.Menu_Book_Add.Click += new System.EventHandler(this.Menu_Book_Add_Click);
            // 
            // Menu_Book_Search
            // 
            this.Menu_Book_Search.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Book_Search.Image")));
            this.Menu_Book_Search.Name = "Menu_Book_Search";
            this.Menu_Book_Search.Size = new System.Drawing.Size(180, 22);
            this.Menu_Book_Search.Text = "&Search";
            this.Menu_Book_Search.Click += new System.EventHandler(this.Menu_Book_Search_Click);
            // 
            // Menu_Book_Update
            // 
            this.Menu_Book_Update.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Book_Update.Image")));
            this.Menu_Book_Update.Name = "Menu_Book_Update";
            this.Menu_Book_Update.Size = new System.Drawing.Size(180, 22);
            this.Menu_Book_Update.Text = "&Update";
            this.Menu_Book_Update.Click += new System.EventHandler(this.Menu_Book_Update_Click);
            // 
            // Menu_Book_Borrow_s
            // 
            this.Menu_Book_Borrow_s.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Book_Borrow_s.Image")));
            this.Menu_Book_Borrow_s.Name = "Menu_Book_Borrow_s";
            this.Menu_Book_Borrow_s.Size = new System.Drawing.Size(180, 22);
            this.Menu_Book_Borrow_s.Text = "&Borrow";
            this.Menu_Book_Borrow_s.Click += new System.EventHandler(this.Menu_Book_Borrow_Click);
            // 
            // Menu_Student
            // 
            this.Menu_Student.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Student_Add,
            this.Menu_Student_Search,
            this.Menu_Student_Update});
            this.Menu_Student.Name = "Menu_Student";
            this.Menu_Student.Size = new System.Drawing.Size(60, 20);
            this.Menu_Student.Text = "&Student";
            // 
            // Menu_Student_Add
            // 
            this.Menu_Student_Add.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Student_Add.Image")));
            this.Menu_Student_Add.Name = "Menu_Student_Add";
            this.Menu_Student_Add.Size = new System.Drawing.Size(112, 22);
            this.Menu_Student_Add.Text = "&Add";
            this.Menu_Student_Add.Click += new System.EventHandler(this.Menu_Student_Add_Click);
            // 
            // Menu_Student_Search
            // 
            this.Menu_Student_Search.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Student_Search.Image")));
            this.Menu_Student_Search.Name = "Menu_Student_Search";
            this.Menu_Student_Search.Size = new System.Drawing.Size(112, 22);
            this.Menu_Student_Search.Text = "&Search";
            this.Menu_Student_Search.Click += new System.EventHandler(this.Menu_Student_Search_Click);
            // 
            // Menu_Student_Update
            // 
            this.Menu_Student_Update.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Student_Update.Image")));
            this.Menu_Student_Update.Name = "Menu_Student_Update";
            this.Menu_Student_Update.Size = new System.Drawing.Size(112, 22);
            this.Menu_Student_Update.Text = "&Update";
            this.Menu_Student_Update.Click += new System.EventHandler(this.Menu_Student_Update_Click);
            // 
            // Menu_Employee
            // 
            this.Menu_Employee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Employee_Add,
            this.Menu_Employee_Search,
            this.Menu_Employee_Update});
            this.Menu_Employee.Name = "Menu_Employee";
            this.Menu_Employee.Size = new System.Drawing.Size(71, 20);
            this.Menu_Employee.Text = "&Employee";
            // 
            // Menu_Employee_Add
            // 
            this.Menu_Employee_Add.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Employee_Add.Image")));
            this.Menu_Employee_Add.Name = "Menu_Employee_Add";
            this.Menu_Employee_Add.Size = new System.Drawing.Size(112, 22);
            this.Menu_Employee_Add.Text = "&Add";
            this.Menu_Employee_Add.Click += new System.EventHandler(this.Menu_Employee_Add_Click);
            // 
            // Menu_Employee_Search
            // 
            this.Menu_Employee_Search.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Employee_Search.Image")));
            this.Menu_Employee_Search.Name = "Menu_Employee_Search";
            this.Menu_Employee_Search.Size = new System.Drawing.Size(112, 22);
            this.Menu_Employee_Search.Text = "&Search";
            this.Menu_Employee_Search.Click += new System.EventHandler(this.Menu_Employee_Search_Click);
            // 
            // Menu_Employee_Update
            // 
            this.Menu_Employee_Update.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Employee_Update.Image")));
            this.Menu_Employee_Update.Name = "Menu_Employee_Update";
            this.Menu_Employee_Update.Size = new System.Drawing.Size(112, 22);
            this.Menu_Employee_Update.Text = "&Update";
            this.Menu_Employee_Update.Click += new System.EventHandler(this.Menu_Employee_Update_Click);
            // 
            // Menu_Help
            // 
            this.Menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Help_View_Help,
            this.toolStripSeparator1,
            this.Menu_Help_About});
            this.Menu_Help.Name = "Menu_Help";
            this.Menu_Help.Size = new System.Drawing.Size(44, 20);
            this.Menu_Help.Text = "&Help";
            // 
            // Menu_Help_View_Help
            // 
            this.Menu_Help_View_Help.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Help_View_Help.Image")));
            this.Menu_Help_View_Help.Name = "Menu_Help_View_Help";
            this.Menu_Help_View_Help.Size = new System.Drawing.Size(127, 22);
            this.Menu_Help_View_Help.Text = "&View Help";
            this.Menu_Help_View_Help.Click += new System.EventHandler(this.Menu_Help_View_Help_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // Menu_Help_About
            // 
            this.Menu_Help_About.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Help_About.Image")));
            this.Menu_Help_About.Name = "Menu_Help_About";
            this.Menu_Help_About.Size = new System.Drawing.Size(127, 22);
            this.Menu_Help_About.Text = "&About";
            this.Menu_Help_About.Click += new System.EventHandler(this.Menu_Help_About_Click);
            // 
            // Menu_Book_Borrow_e
            // 
            this.Menu_Book_Borrow_e.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Book_Borrow_e.Image")));
            this.Menu_Book_Borrow_e.Name = "Menu_Book_Borrow_e";
            this.Menu_Book_Borrow_e.Size = new System.Drawing.Size(180, 22);
            this.Menu_Book_Borrow_e.Text = "&Borrow";
            this.Menu_Book_Borrow_e.Click += new System.EventHandler(this.Menu_Book_Borrow_e_Click);
            // 
            // Form_Main_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.menu_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_panel;
            this.Name = "Form_Main_Panel";
            this.Text = "Main_Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_Panel_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Panel_Load);
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_panel;
        private System.Windows.Forms.ToolStripMenuItem Menu_Book;
        private System.Windows.Forms.ToolStripMenuItem Menu_Book_Add;
        private System.Windows.Forms.ToolStripMenuItem Menu_Book_Search;
        private System.Windows.Forms.ToolStripMenuItem Menu_Book_Update;
        private System.Windows.Forms.ToolStripMenuItem Menu_Student;
        private System.Windows.Forms.ToolStripMenuItem Menu_Student_Add;
        private System.Windows.Forms.ToolStripMenuItem Menu_Student_Search;
        private System.Windows.Forms.ToolStripMenuItem Menu_Student_Update;
        private System.Windows.Forms.ToolStripMenuItem Menu_Employee;
        private System.Windows.Forms.ToolStripMenuItem Menu_Employee_Add;
        private System.Windows.Forms.ToolStripMenuItem Menu_Employee_Search;
        private System.Windows.Forms.ToolStripMenuItem Menu_Employee_Update;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help_View_Help;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help_About;
        private System.Windows.Forms.ToolStripMenuItem Menu_Book_Borrow_s;
        private System.Windows.Forms.ToolStripMenuItem Menu_Book_Borrow_e;
    }
}