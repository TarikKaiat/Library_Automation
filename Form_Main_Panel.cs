using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation
{
      
    public partial class Form_Main_Panel : Form
    {
        public byte k;


        public Form_Main_Panel(byte k)
        {
            InitializeComponent();

            switch (k)
            {
                case 2 :
                    Menu_Employee.Visible = false;
                    Menu_Student.Visible = false;
                    Menu_Book_Add.Visible = false;
                    Menu_Book_Update.Visible = false;
                    Menu_Book_Borrow_e.Visible = false;

                break;

                case 1:
                    Menu_Employee.Visible = false;
                    Menu_Book_Borrow_s.Visible = false;
                break;
                case 0:
                   
                    Menu_Book_Borrow_s.Visible = false;
              break;

            }
                
   
        }

       

        


        private void Form_Main_Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Employee_Add_Click(object sender, EventArgs e)
        {
            Form_Employee_Add newMDIChild = new Form_Employee_Add();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }

        private void Menu_Employee_Search_Click(object sender, EventArgs e)
        {
            Form_Employee_Liste newMDIChild = new Form_Employee_Liste();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }

        private void Menu_Employee_Update_Click(object sender, EventArgs e)
        {
            Form_Employee_Update newMDIChild = new Form_Employee_Update();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }

        private void Menu_Student_Add_Click(object sender, EventArgs e)
        {
            Form_Student_Add newMDIChild = new Form_Student_Add();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }

        private void Menu_Student_Search_Click(object sender, EventArgs e)
        {
            Form_Student_Liste newMDIChild = new Form_Student_Liste();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }

        private void Menu_Student_Update_Click(object sender, EventArgs e)
        {
            Form_Student_Update newMDIChild = new Form_Student_Update();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }

        private void Menu_Book_Add_Click(object sender, EventArgs e)
        {
            Form_Book_Add newMDIChild = new Form_Book_Add();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }

        private void Menu_Book_Search_Click(object sender, EventArgs e)
        {
            Form_Book_Liste newMDIChild = new Form_Book_Liste();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }

        private void Menu_Book_Update_Click(object sender, EventArgs e)
        {
            Form_Book_Update newMDIChild = new Form_Book_Update();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }

        private void Menu_Help_About_Click(object sender, EventArgs e)
        {
            string massage = "Creat By FrEe For DBMS Project";
            string title = "About Us";
            MessageBox.Show(massage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Menu_Book_Borrow_Click(object sender, EventArgs e)
        {
            Form_Book_Borrow_S newMDIChild = new Form_Book_Borrow_S();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }

        private void Form_Main_Panel_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = System.Drawing.ColorTranslator.FromHtml("#426e86");
                    // 4#
                    break;
                }
            }

            

        }

       

        private void Menu_Library_Department_Click(object sender, EventArgs e)
        {
            Form_Employee_Add newMDIChild = new Form_Employee_Add();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }



        private void Menu_Help_View_Help_Click(object sender, EventArgs e)
        {
            string massage = "Contact us for support : ammarrahmouni8@gmail.com";
            string title = "Contact Us";
            MessageBox.Show(massage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Menu_Book_Borrow_e_Click(object sender, EventArgs e)
        {
            Form_Book_Borrow_E newMDIChild = new Form_Book_Borrow_E();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Location = new Point(0, 0);
        }
    }
    }
