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
    public partial class Form_Book_Borrow_E : Form
    {
        public int i = -1, s = -1, tm = -1;
        public int daysOfDelay;
        public string email_user;
        Student student = new Student();
        public Form_Book_Borrow_E()
        {
            InitializeComponent();
        }

        private void txt_stu_id_TextChanged(object sender, EventArgs e)
        {
            if (txt_stu_id.Text != "")
            {
                dataGridView1.DataSource = DAO.searchStudent(txt_stu_id.Text).Tables[0];
            }
            else {
                dataGridView1.DataSource = null;
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DAO.openConnection();
            MySqlDataReader myReader;
            MySqlCommand sql3 = new MySqlCommand("SELECT * FROM library.books  WHERE book_title = '" + txt_book_id.Text+ "'", con);
            myReader = sql3.ExecuteReader();
            if (!myReader.HasRows)
            {
                lab_title_d.Text = "";
                lab_autor_d.Text = "";
                lab_description_d.Text = "";
                lab_count_d.Text = "";
                lab_department_d.Text = "";
                MessageBox.Show("This book does not exist !!");
            }

            else {
                myReader.Close();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM library.books  WHERE book_title = @book or book_auth = @book", con);
            sql.Parameters.AddWithValue("@book", txt_book_id.Text);
            myReader = sql.ExecuteReader();

            try
            {
                
                while (myReader.Read())
                    {
                        lab_title_d.Text = myReader["book_title"].ToString();
                        lab_autor_d.Text = myReader["book_auth"].ToString();
                        lab_description_d.Text = myReader["book_description"].ToString();
                        lab_count_d.Text = myReader["book_count"].ToString();

                        i = Convert.ToInt32(myReader["department_id"].ToString());
                    }


                myReader.Close();

                MySqlCommand sql_1 = new MySqlCommand("SELECT * FROM library.departments  WHERE department_id = @book", con);
                sql_1.Parameters.AddWithValue("@book", i);

                MySqlDataReader reader = sql_1.ExecuteReader();
                while (reader.Read())
                {
                    lab_department_d.Text = reader["department_title"].ToString();
                }
                reader.Close();
            }
            catch (Exception es)
            {
                throw;
            }
            finally
            {
                myReader.Close();

                DAO.connectionClose(con);
            }
            
        }
     }

        private void btn_return_Click(object sender, EventArgs e)
        {
           
            
            if (txt_book_id.Text.Equals("") && txt_stu_id.Text.Equals(""))
            {
                MessageBox.Show("Please fill all fields");
            }

          
            else if (lab_count_d.Text.Equals("")) {
                MessageBox.Show("Please enter the book information you want to check out!!");
            }

            else if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {


                MySqlConnection con = DAO.openConnection();
                MySqlCommand sql_1 = new MySqlCommand("SELECT * FROM library.books  WHERE book_title = @book", con);
                sql_1.Parameters.AddWithValue("@book", lab_title_d.Text);
                MySqlDataReader reader = sql_1.ExecuteReader(); ;
                int i = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());



                try
                {
                    while (reader.Read())
                    {
                        s = Convert.ToInt32(reader["book_id"].ToString());
                    }
                    reader.Close();
                    if (!DAO.isExists(s, i))
                    {
                        MessageBox.Show("The book is not taken");
                    }
                    else {

                        MySqlCommand sql2 = new MySqlCommand("Update library.borrow set return_date = CURDATE(),days_of_delay = DATEDIFF(CURRENT_DATE(),borrow_date) ", con);
                        sql2.Parameters.AddWithValue("@stuID", i);
                        sql2.Parameters.AddWithValue("@bookID", s);
                        sql2.ExecuteNonQuery();

                        MySqlCommand sql_2 = new MySqlCommand("Select * From library.borrow WHERE book_id = " + s + " AND student_id = " + i, con);
                        MySqlDataReader reader2 = sql_2.ExecuteReader();
                        while (reader2.Read())
                        {
                            daysOfDelay = Convert.ToInt32(reader2["days_of_delay"].ToString());
                        }
                        if(daysOfDelay > 15)
                        {
                            MessageBox.Show(" You have a penalty of: " + (daysOfDelay * 0.25).ToString() + "tl");

                        }
                        else
                        {
                            MessageBox.Show("There is now penalty the book was returned on time.");

                        }
                        reader2.Close();
                        MySqlCommand sql4 = new MySqlCommand("Delete From library.borrow WHERE book_id = " + s + " AND student_id = " + i, con);
                        sql4.Parameters.AddWithValue("@stuID", i);
                        sql4.Parameters.AddWithValue("@bookID", s);
                        sql4.ExecuteNonQuery();
                        lab_count_d.Text = (Convert.ToInt32(lab_count_d.Text) + 1).ToString();
                        MessageBox.Show("The operation is completed.");
                        txt_book_id.Text = "";
                        txt_stu_id.Text = "";
                        lab_title_d.Text = "";
                        lab_autor_d.Text = "";
                        lab_description_d.Text = "";
                        lab_department_d.Text = "";
                        lab_count_d.Text = "";
                        txt_stu_id_Leave(sender, e);
                        txt_book_id_Leave(sender, e);
                    }

                }

                catch (Exception es)
                {
                    throw;
                }
                finally
                {
                    reader.Close();
                    DAO.connectionClose(con);
                }


            }
            else
            {
                MessageBox.Show("Please choose the student from the list");
            }

        }

        private void txt_book_id_Enter(object sender, EventArgs e)
        {
            if (txt_book_id.Text == "Book Title or Auther") {
                txt_book_id.Text = "";
                txt_book_id.ForeColor = Color.Black;
            }
        }

        private void txt_book_id_Leave(object sender, EventArgs e)
        {
            if (txt_book_id.Text == "")
            {
                txt_book_id.Text = "Book Title or Auther";
                txt_book_id.ForeColor = Color.Silver;
            }
        }

        private void txt_stu_id_Enter(object sender, EventArgs e)
        {
            if (txt_stu_id.Text == "T.C. , Name , Surname or Email")
            {
                txt_stu_id.Text = "";
                txt_stu_id.ForeColor = Color.Black;
            }
        }

        private void txt_stu_id_Leave(object sender, EventArgs e)
        {
            if (txt_stu_id.Text == "")
            {
                txt_stu_id.Text = "T.C. , Name , Surname or Email";
                txt_stu_id.ForeColor = Color.Silver;
            }
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

        private bool SendEmail(string email, string book)
        {   
            if (IsValidEmail(email))
            {

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new System.Net.NetworkCredential("amaasdassda@gmail.com", "05366394454");
                client.EnableSsl = true;
                MailMessage mail = new MailMessage("amaasdassda@gmail.com", email , "Library System" ,"You borrowed a " + book + " book from the library, in the history of " + DateTime.Now + ". We wish you a happy reading. Please return the book after 15 days, from the current date");
                mail.IsBodyHtml = false;
                client.Send(mail);
                
                return true;
            }
            else
            {
                return false;
            }


        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (txt_book_id.Text.Equals("") && txt_stu_id.Text.Equals(""))
            {
                MessageBox.Show("Please fill all fields");
            }

          
            else if (lab_count_d.Text.Equals("")) {
                MessageBox.Show("Please enter the book information you want to check out!!");
            }
            else if (Convert.ToInt32(lab_count_d.Text) < 1)
            {
                MessageBox.Show("There are not enough books to perform the operation!!");

            }

            else if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {


                MySqlConnection con = DAO.openConnection();
                MySqlCommand sql_1 = new MySqlCommand("SELECT * FROM library.books  WHERE book_title = @book", con);
                sql_1.Parameters.AddWithValue("@book", lab_title_d.Text);
                MySqlDataReader reader = sql_1.ExecuteReader(); 
                tm = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                email_user = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[5].Value.ToString();



                try
                {
                    while (reader.Read())
                    {
                        s = Convert.ToInt32(reader["book_id"].ToString());
                    }
                    reader.Close();
                    if (DAO.isExists(s, tm))
                    {
                        MessageBox.Show("The book was taken in advance!!!");
                    }
                    else {
                        if (SendEmail(email_user, lab_title_d.Text))
                        {
                            MySqlCommand sql = new MySqlCommand("INSERT INTO library.borrow (student_id, book_id, borrow_date) VALUES (@stuID, @bookID, CURDATE()) ", con);
                            sql.Parameters.AddWithValue("@stuID", tm);
                            sql.Parameters.AddWithValue("@bookID", s);
                            sql.ExecuteNonQuery();

                            MySqlCommand sql_2 = new MySqlCommand("UPDATE library.books SET book_count = book_count - 1 WHERE book_id = " + s, con);
                            sql_2.ExecuteNonQuery();
                            lab_count_d.Text = (Convert.ToInt32(lab_count_d.Text) - 1).ToString();

                            string messesge = "The operation is completed.";
                            string title = "succefull";
                            MessageBox.Show(messesge, title, MessageBoxButtons.OK, MessageBoxIcon.None);

                            txt_book_id.Text = "";
                            txt_stu_id.Text = "";
                            lab_title_d.Text = "";
                            lab_autor_d.Text = "";
                            lab_description_d.Text = "";
                            lab_department_d.Text = "";
                            lab_count_d.Text = "";
                            txt_stu_id_Leave(sender, e);
                            txt_book_id_Leave(sender, e);
                        }
                        else {
                            string messesge = "An error occurred during the borrowing process, please try again later";
                            string title = "Error";

                            MessageBox.Show(messesge, title, MessageBoxButtons.OK, MessageBoxIcon.None);
                        }



                    }

                }

                catch (Exception es)
                {
                    throw;
                }
                finally
                {
                    reader.Close();
                    DAO.connectionClose(con);
                }


            }
            else
            {
                string messesge = "Please choose the student from the list";
                string title = "Error";
                MessageBox.Show(messesge, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
