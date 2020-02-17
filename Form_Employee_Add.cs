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
    public partial class Form_Employee_Add : Form
    {
        Employee employee = DAO.employee;

        public Form_Employee_Add()
        {
            InitializeComponent();
        }



        private void btn_add_Click_1(object sender, EventArgs e)
        {

            MySqlConnection con =DAO.openConnection();
            bool sonuc;
            MySqlCommand cmd;
            try
            {
                
                    cmd = new MySqlCommand("select * from library.students Where student_email=@uID or student_tc=@uTC or student_phone=@uPhone", con);
              

                cmd.Parameters.AddWithValue("@uID",text_email.Text.ToString());
                cmd.Parameters.AddWithValue("@uTC", text_tc.Text.ToString());
                cmd.Parameters.AddWithValue("@uPhone", text_phone.Text.ToString());
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();


                if (text_name.Text != "" && text_surname.Text != "" && text_password.Text != "" && text_start_date.Text != ""
               && text_email.Text != "" && text_phone.Text != "" && text_tc.Text != "" && text_salary.Text != "" && text_address.Text != "")
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

                    if (!rdr.HasRows && DAO.insertEmployee(employee) )
                    {
                        MessageBox.Show("The addition was successful");
                        text_name.Text = "";
                        text_phone.Text = "";
                        text_password.Text = "";
                        text_salary.Text = "";
                        text_email.Text = "";
                        text_address.Text = "";
                        text_start_date.Text = "";
                        text_tc.Text = "";
                        text_surname.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("The addition was Unsuccessful, Make sure that T.C., phone number or email are not repeated");
                    }

                }
                else
                {
                    MessageBox.Show("Please fill in all");
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

    }
}
