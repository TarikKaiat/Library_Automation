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
    public partial class Form_Book_Add : Form
    {
        public Form_Book_Add()
        {
            InitializeComponent();
        }

        private void Form_Book_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_title.Text != "" && txt_autor.Text != "" && combo_department.SelectedIndex >= 0 && txt_description.Text != "" && txt_count.Text != "")

            {

                if (DAO.insertBook(txt_title.Text, combo_department.SelectedIndex, txt_autor.Text, txt_description.Text, Convert.ToInt32(txt_count.Text)))
                {
                    MessageBox.Show("The addition was successful");
                    txt_title.Text = "";
                    txt_autor.Text = "";
                    combo_department.Text = "";
                    txt_description.Text = "";
                    txt_count.Text = "";
                }
                else
                {
                    MessageBox.Show("The addition was Unsuccessful");
                }

            }
            else {
                MessageBox.Show("Please fill in all");
            }
           
        }

    }
}
 