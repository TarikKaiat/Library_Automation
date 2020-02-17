using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Automation
{
    public partial class Form_Student_Update : Form
    {
        Student student = DAO.student;
        public Form_Student_Update()
        {
            InitializeComponent();
            
        }

        private void lab_status_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DAO.openConnection();
            bool sonuc;
            MySqlCommand cmd;
            try
            {

                cmd = new MySqlCommand("select * from library.employees Where employee_email=@uID or employee_tc=@uTC or employee_phone=@uPhone", con);


                cmd.Parameters.AddWithValue("@uID", txt_email.Text.ToString());
                cmd.Parameters.AddWithValue("@uTC", txt_tc.Text.ToString());
                cmd.Parameters.AddWithValue("@uPhone", txt_phone.Text.ToString());
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();

                if (txt_query.Text == "")
            {
                MessageBox.Show("Please first search for the student");
            }

            else if (txt_name.Text != "" && txt_surname.Text != "" && txt_password.Text != "" && combo_level.Text != ""
                && text_email.Text != "" && text_phone.Text != "" && txt_address.Text != "" && txt_tc.Text != "")
            {
                if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    student.setsAddress(txt_address.Text);
                    student.setsEmail(txt_email.Text);
                    student.setsName(txt_name.Text);
                    student.setsPassword(txt_password.Text);
                    student.setsPhone(txt_phone.Text);
                    student.setsSurname(txt_surname.Text);
                    student.setsTc(txt_tc.Text);
                    student.setLevelID(combo_level.SelectedIndex + 1);

                    if  (!rdr.HasRows && DAO.updateStudent(student, Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("The Update Is successful");
                        txt_name.Text = "";
                        txt_surname.Text = "";
                        txt_password.Text = "";
                        txt_email.Text = "";
                        txt_phone.Text = "";
                        txt_address.Text = "";
                        txt_tc.Text = "";
                        combo_level.SelectedIndex = -1;
                        txt_query.Text = "";
                        dataGridView1.DataSource = null;
                    }
                    else {
                        MessageBox.Show("The addition was Unsuccessful, Make sure that T.C., phone number or email are not repeated");
                    }

                }
                else
                {
                    MessageBox.Show("Please Select The student from the list");
                }

            }

            else
            {
                MessageBox.Show("Please Fill all the fields");
            }
            }
            catch (Exception es)
            {
                es.Message.ToString();
                MessageBox.Show("The addition was Unsuccessful, Make sure that T.C., phone number or email are not repeated");


            }
            finally
            {
                DAO.connectionClose(con);
            }
        }

        private void txt_query_TextChanged(object sender, EventArgs e)
        {

            if (txt_query.Text != "")
            {
                dataGridView1.DataSource = DAO.searchStudent(txt_query.Text).Tables[0];
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
        

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DAO.openConnection();

            try
            {
                int i = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                MySqlCommand sql_1 = new MySqlCommand("SELECT (student_id) FROM library.borrow  WHERE student_id = @Sid", con);
                sql_1.Parameters.AddWithValue("@Sid", i);
                MySqlDataReader reader = sql_1.ExecuteReader();

                if (txt_query.Text == "")
                {
                    MessageBox.Show("Please first search for the student");
                }
                else if (reader.Read())
                {

                    MessageBox.Show("This student has borrowed books from the library and has not returned them. The student cannot be deleted unless the book he borrowed is returned");
                }
                else if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DAO.delete("students", Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    MessageBox.Show("The Delete Is successful");
                    dataGridView1.DataSource = DAO.searchStudent(txt_query.Text).Tables[0];
                    txt_address.Text = "";
                    txt_email.Text = "";
                    txt_name.Text = "";
                    txt_password.Text = "";
                    txt_phone.Text = "";
                    txt_query.Text = "";
                    txt_surname.Text = "";
                    txt_tc.Text = "";
                    combo_level.SelectedIndex = -1;

                }

                else
                {
                    MessageBox.Show("Please Select The student");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Please Select The student");
            }
            finally {
                DAO.connectionClose(con);
            }


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_password.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();
            txt_name.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString();
            txt_surname.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();
            combo_level.SelectedIndex = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[4].Value.ToString())-1;
            txt_email.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[5].Value.ToString();
            txt_phone.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[6].Value.ToString();
            txt_tc.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[7].Value.ToString();
            txt_address.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[8].Value.ToString();
        }
    }
}
