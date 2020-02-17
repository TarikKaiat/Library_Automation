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
    public partial class Form_Employee_Update : Form
    {
        Employee employee = DAO.employee;
        public Form_Employee_Update()
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

                cmd = new MySqlCommand("select * from library.students Where student_email=@uID or student_tc=@uTC or student_phone=@uPhone", con);


                cmd.Parameters.AddWithValue("@uID", text_email.Text.ToString());
                cmd.Parameters.AddWithValue("@uTC", text_tc.Text.ToString());
                cmd.Parameters.AddWithValue("@uPhone", text_phone.Text.ToString());
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();


                if (txt_query.Text == "")
                {
                    MessageBox.Show("Please first search for the employee");
                }

                else if (text_name.Text != "" && text_surname.Text != "" && text_password.Text != "" && text_start_date.Text != ""
                    && text_email.Text != "" && text_phone.Text != "" && text_tc.Text != "" && text_salary.Text != "" && text_address.Text != "")
                {
                    if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                    {
                        employee.seteAddress(text_address.Text);
                        employee.seteEmail(text_email.Text);
                        employee.seteName(text_name.Text);
                        employee.setePassword(text_password.Text);
                        employee.setePhone(text_phone.Text);
                        employee.seteSalary(Convert.ToInt32(text_salary.Text));
                        employee.seteStartdate(text_start_date.Text);
                        employee.seteSurname(text_surname.Text);
                        employee.seteTc(text_tc.Text);

                        if (!rdr.HasRows && DAO.updateEmployee(employee, Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString())))
                        {
                            MessageBox.Show("The Update Is successful");
                            text_name.Text = "";
                            text_phone.Text = "";
                            text_password.Text = "";
                            text_salary.Text = "";
                            text_email.Text = "";
                            text_start_date.Text = "";
                            text_tc.Text = "";
                            text_surname.Text = "";
                            text_address.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("The addition was Unsuccessful, Make sure that T.C., phone number or email are not repeated");
                        }



                    }
                    else
                    {
                        MessageBox.Show("Please Select The employee from the list");
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
                dataGridView1.DataSource = DAO.searchEmployee(txt_query.Text).Tables[0];

            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_query.Text == "")
            {
                MessageBox.Show("Please first search for the employee");
            }

            else if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DAO.delete("employees", Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString()));
                MessageBox.Show("The Delete Is successful");
                dataGridView1.DataSource = DAO.searchEmployee(txt_query.Text).Tables[0];
                text_name.Text = "";
                text_phone.Text = "";
                text_password.Text = "";
                text_salary.Text = "";
                text_email.Text = "";
                text_start_date.Text = "";
                text_tc.Text = "";
                text_surname.Text = "";
                text_address.Text = "";
                txt_query.Text = "";

            }
            else
            {
                MessageBox.Show("Please Select The empolyee");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            text_password.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();
            text_name.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString();
            text_surname.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();
            text_email.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[5].Value.ToString();
            text_phone.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[6].Value.ToString();
            text_tc.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[7].Value.ToString();
            text_salary.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[9].Value.ToString();
            text_start_date.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[4].Value.ToString();
            text_address.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[8].Value.ToString();
        }
    }
}
