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
    public partial class Form_Book_Borrow_S : Form
    {
       public int s = -1;
        public Form_Book_Borrow_S()
        {
            InitializeComponent();
        }

        private void Form_Book_Borrow_S_Load(object sender, EventArgs e)
        {
            string email = DAO.user.getuserEmail();

            MySqlConnection con = DAO.openConnection();
            MySqlCommand sql_1 = new MySqlCommand("SELECT * FROM library.students  WHERE student_email = @email", con);
            sql_1.Parameters.AddWithValue("@email", email);
            MySqlDataReader reader = sql_1.ExecuteReader();

            while (reader.Read())
            {
                s = Convert.ToInt32(reader["student_id"].ToString());
            }
            reader.Close();

            MySqlCommand sql_2 = new MySqlCommand("SELECT book_title, borrow_date FROM library.borrow JOIN library.books  ON borrow.book_id = books.book_id WHERE student_id = @stuID", con);
            sql_2.Parameters.AddWithValue("@stuID", s);
            sql_2.ExecuteNonQuery();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql_2);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            data_liste.DataSource = dataSet.Tables[0];
        }
    }
}
