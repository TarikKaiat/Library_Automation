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
    public partial class Form_Book_Update : Form
    {
        public Form_Book_Update()
        {
            InitializeComponent();
            
        }

        

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_query.Text == "") {
                MessageBox.Show("Please first search for the book");
            }

            else if (txt_title.Text != "" && txt_autor.Text != "" && txt_description.Text != "" && combo_department.SelectedItem.ToString() != ""  && txt_count.Text != "")  
            {
                if( dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DAO.updateBook(txt_title.Text, combo_department.SelectedIndex, txt_autor.Text, txt_description.Text,
                    Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString()), Convert.ToInt32(txt_count.Text));
                    MessageBox.Show("The Update Is successful");
                    txt_title.Text = "";
                    txt_autor.Text = "";
                    combo_department.Text = "";
                    txt_description.Text = "";
                    txt_count.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Select The Book");
                }

            }

            else
            {
                MessageBox.Show("Please Fill all the fields");
            }
 
        }




        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_query.Text == "")
            {
                MessageBox.Show("Please first search for the book");
            }
           
            else if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DAO.delete("books", Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString()));
                MessageBox.Show("The Delete Is successful");
                dataGridView1.DataSource = DAO.searchBook(txt_query.Text).Tables[0];
                txt_title.Text = "";
                txt_autor.Text = "";
                combo_department.Text = "";
                txt_description.Text = "";
                txt_count.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select The Book");
            }

        }

          

        private void txt_query_TextChanged(object sender, EventArgs e)
        {
            if (txt_query.Text != "")
            {
                dataGridView1.DataSource = DAO.searchBook(txt_query.Text).Tables[0];
            }
            else {
                dataGridView1.DataSource = null;
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_title.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();
            txt_autor.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();
            txt_count.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[5].Value.ToString();
            txt_description.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[4].Value.ToString();
             combo_department.SelectedIndex = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString()) ;
        }
    }


 }

