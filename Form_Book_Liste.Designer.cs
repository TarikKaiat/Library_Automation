namespace Library_Automation
{
    partial class Form_Book_Liste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Book_Liste));
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_liste = new System.Windows.Forms.DataGridView();
            this.lab_search = new System.Windows.Forms.Label();
            this.txt_query = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_liste)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.data_liste);
            this.panel1.Controls.Add(this.lab_search);
            this.panel1.Controls.Add(this.txt_query);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 384);
            this.panel1.TabIndex = 0;
            // 
            // data_liste
            // 
            this.data_liste.AllowUserToAddRows = false;
            this.data_liste.AllowUserToDeleteRows = false;
            this.data_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_liste.Location = new System.Drawing.Point(0, 85);
            this.data_liste.Name = "data_liste";
            this.data_liste.Size = new System.Drawing.Size(691, 296);
            this.data_liste.TabIndex = 2;
            // 
            // lab_search
            // 
            this.lab_search.AutoSize = true;
            this.lab_search.Location = new System.Drawing.Point(198, 25);
            this.lab_search.Name = "lab_search";
            this.lab_search.Size = new System.Drawing.Size(40, 13);
            this.lab_search.TabIndex = 1;
            this.lab_search.Text = "Search";
            // 
            // txt_query
            // 
            this.txt_query.Location = new System.Drawing.Point(254, 22);
            this.txt_query.Name = "txt_query";
            this.txt_query.Size = new System.Drawing.Size(236, 20);
            this.txt_query.TabIndex = 1;
            this.txt_query.TextChanged += new System.EventHandler(this.txt_query_TextChanged);
            // 
            // Form_Book_Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(689, 379);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Book_Liste";
            this.Text = "Book Liste";
            this.Load += new System.EventHandler(this.Form_Book_Liste_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_query;
        private System.Windows.Forms.DataGridView data_liste;
        private System.Windows.Forms.Label lab_search;
    }
}