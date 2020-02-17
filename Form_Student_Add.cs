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
using System.Net.Mail;

namespace Library_Automation
{
    public partial class Form_Student_Add : Form
    {
        public Form_Student_Add()
        {
            InitializeComponent();
        }
        Student student = DAO.student;


        private void Form_Student_Load(object sender, EventArgs e)
        {
            
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private  bool SendEmail(string email, string name, string soname, string password)
        {
            if (IsValidEmail(email))
            {   //omar7alabi96@gmail.com

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new System.Net.NetworkCredential("amaasdassda@gmail.com", "05366394454");
                client.EnableSsl = true;
                MailMessage mail = new MailMessage("amaasdassda@gmail.com", txt_email.Text, "Library system", "Registered successfully, Welcome Mr. " + name.ToUpper() + " " + soname.ToUpper() + " in our library.Your password is: " + password + " Please keep your password  .Starting from today you can now borrow books for free from the library. We hope you have a good time with us.");
                mail.IsBodyHtml = false;
                client.Send(mail);

                MessageBox.Show("A verification email has been sent successfully");
                return true;
            }
            else {
                return false;
            }


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DAO.openConnection();
            MySqlCommand cmd;
            try
            {
                cmd = new MySqlCommand("select * from library.employees Where employee_email=@uID or employee_tc=@uTC or employee_phone=@uPhone", con);
                cmd.Parameters.AddWithValue("@uID", txt_email.Text.ToString());
                cmd.Parameters.AddWithValue("@uTC", txt_tc.Text.ToString());
                cmd.Parameters.AddWithValue("@uPhone", txt_phone.Text.ToString());
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

              

                if (txt_name.Text != "" && txt_surname.Text != "" && txt_password.Text != "" && combo_level.SelectedIndex >= 0
                    && text_email.Text != "" && text_phone.Text != "" && txt_address.Text != "" && txt_tc.Text != "" )
                {
                    student.setsAddress(txt_address.Text);
                    student.setsEmail(txt_email.Text);
                    student.setsName(txt_name.Text);
                    student.setsPassword(txt_password.Text);
                    student.setsPhone(txt_phone.Text);
                    student.setsSurname(txt_surname.Text);
                    student.setsTc(txt_tc.Text);
                    student.setLevelID(combo_level.SelectedIndex + 1);

                    if (!rdr.HasRows && DAO.insertStudent(student) && SendEmail(student.getsEmail(), student.getsName(), student.getsSurname(), student.getsPassword()))
                    {
                        MessageBox.Show("The addition was successful");
                        txt_name.Text = "";
                        txt_surname.Text = "";
                        txt_password.Text = "";
                        txt_email.Text = "";
                        txt_phone.Text = "";
                        txt_address.Text = "";
                        txt_tc.Text = "";
                        combo_level.SelectedIndex = -1;
                    }
                    else if (!IsValidEmail(student.getsEmail())) {
                        MessageBox.Show("Email is not valid, please check again");

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
                MessageBox.Show(es.Message.ToString());

            }
            finally
            {
                DAO.connectionClose(con);
            }
        }


    }

     
 }

