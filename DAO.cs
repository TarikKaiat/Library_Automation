using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Automation
{

    class DAO
    {
        public static Student student = new Student();
        public static Employee employee = new Employee();
        public static User user = new User();
         
        public static bool userLogin(User u,int i)
        {
            MySqlConnection con = openConnection();
            bool sonuc;
            MySqlCommand cmd;
            try
            {   
                if (i == 1)
                {
                     cmd = new MySqlCommand("select * from library.students Where student_email=@uID and student_password=@password", con);
                }
                else
                {
                     cmd = new MySqlCommand("select * from library.employees Where employee_email=@uID and employee_password=@password", con);
                }

                cmd.Parameters.AddWithValue("@uID", user.getuserEmail());
                cmd.Parameters.AddWithValue("@password", u.getPassword());
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();
                if (rdr.HasRows)
                    sonuc = true;
                else
                    sonuc = false;

            }
            catch (Exception es)
            {
                es.Message.ToString();
                throw es;

            }
            finally
            {
                connectionClose(con);
            }


            return sonuc;


        }

        public static void connectionClose(MySqlConnection conn)
        {
            conn.Close();
        }
        
        public static bool insertBook(string title,int dID,string auth,string desc, int count)
        {
            MySqlConnection con = openConnection();

            try
            {
                MySqlCommand com = new MySqlCommand("library.insert_book", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bTitle", title);
                com.Parameters.AddWithValue("@dID", dID);
                com.Parameters.AddWithValue("@bAuth", auth);
                com.Parameters.AddWithValue("@bDesc", desc);
                com.Parameters.AddWithValue("@bCount", count);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
            finally
            {
                connectionClose(con);
            }
         
        }
        public static DataSet searchBook(String book)
        {   
           
            MySqlConnection con = openConnection();
            DataSet ds = new DataSet();
            try
            {
                 
                 MySqlCommand sql = new MySqlCommand("SELECT * FROM library.books  WHERE book_title like @book or book_auth like @book", con);
                sql.Parameters.AddWithValue("@book","%" + book + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql);
                    adapter.Fill(ds);
                    return ds;



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connectionClose(con);
            }


        }
        public static MySqlCommand getBook(String book)
        {
            MySqlConnection con = openConnection();
            try
            {
                MySqlCommand sql = new MySqlCommand("SELECT * FROM library.books  WHERE book_title like @book or book_auth like @book", con);
                sql.Parameters.AddWithValue("@book", "%" + book + "%");
                return sql;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connectionClose(con);
            }


        }
        public static bool updateBook(string title, int dID, string auth, string desc,int bId, int count)

        {
            DataGridView dataGridViewSearch = new DataGridView();
            MySqlConnection con = openConnection();


            try
            {
                
                MySqlCommand com = new MySqlCommand("library.update_book", con);
                
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bTitle", title);
                com.Parameters.AddWithValue("@bAuth", auth);
                com.Parameters.AddWithValue("@bDepId", dID);
                com.Parameters.AddWithValue("@bDesc", desc);
                com.Parameters.AddWithValue("@bId", bId);
                com.Parameters.AddWithValue("@bCount", count);

                com.ExecuteNonQuery();
                connectionClose(con);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
            finally
            {
                connectionClose(con);
            }

        }
        public static bool insertEmployee(Employee employee)
        {
            MySqlConnection con = openConnection();

            try
            {
                
                MySqlCommand com = new MySqlCommand("library.insert_employee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ePassword", employee.getePassword());
                com.Parameters.AddWithValue("@eName", employee.geteName());
                com.Parameters.AddWithValue("@eSurname", employee.geteSurname());
                com.Parameters.AddWithValue("@eStartDate", employee.geteStartdate());
                com.Parameters.AddWithValue("@eEmail", employee.geteEmail());
                com.Parameters.AddWithValue("@ePhone", employee.getePhone());
                com.Parameters.AddWithValue("@eTc", employee.geteTc());
                com.Parameters.AddWithValue("@eAddress", employee.geteAddress());
                com.Parameters.AddWithValue("@eSalary", employee.geteSalary());
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw;
                return false;
            }
            finally
            {
                connectionClose(con);
            }

        }
        public static DataSet searchEmployee(string employee)
        {
            MySqlConnection con = openConnection();
            DataSet ds = new DataSet();
            try
            {
                MySqlCommand sql = new MySqlCommand("SELECT * FROM library.employees  WHERE employee_name like @employee or employee_surname like @employee or employee_tc like @employee or employee_email like @employee", con);
                sql.Parameters.AddWithValue("@employee",employee + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connectionClose(con);
            }

        }
        public static bool updateEmployee(Employee employee, int id)

        {
            MySqlConnection con = openConnection();


            try
            {
                con = openConnection();
                MySqlCommand com = new MySqlCommand("library.update_employee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ePassword", employee.getePassword());
                com.Parameters.AddWithValue("@eName", employee.geteName());
                com.Parameters.AddWithValue("@eSurname", employee.geteSurname());
                com.Parameters.AddWithValue("@eStartdate", employee.geteStartdate());
                com.Parameters.AddWithValue("@eEmail", employee.geteEmail());
                com.Parameters.AddWithValue("@ePhone", employee.getePhone());
                com.Parameters.AddWithValue("@eTc", employee.geteTc());
                com.Parameters.AddWithValue("@eAddress", employee.geteAddress());
                com.Parameters.AddWithValue("@eSalary", employee.geteSalary());
                com.Parameters.AddWithValue("@eId", id);

                com.ExecuteNonQuery();
                connectionClose(con);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
            finally
            {
                connectionClose(con);
            }

        }
        public static bool insertStudent(Student student)
        {
            MySqlConnection con = openConnection();

            try
            {
                MySqlCommand com = new MySqlCommand("library.insert_student", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@sPassword", student.getsPassword());
                com.Parameters.AddWithValue("@sName", student.getsName());
                com.Parameters.AddWithValue("@sSurname", student.getsSurname());
                com.Parameters.AddWithValue("@sLevelId", student.getLevelID());
                com.Parameters.AddWithValue("@sEmail", student.getsEmail());
                com.Parameters.AddWithValue("@sPhone", student.getsPhone());
                com.Parameters.AddWithValue("@sTc", student.getsTc());
                com.Parameters.AddWithValue("@sAddress", student.getsAddress());
                com.ExecuteNonQuery();
                return true;
            }
            catch(Exception es)
            {
                throw;
                return false;
            }
            finally
            {
                connectionClose(con);
            }
            
        }
        
        public static DataSet searchStudent(string student)
        {
            MySqlConnection con = openConnection();
            DataSet ds;
            try
            {

                MySqlCommand sql = new MySqlCommand("SELECT * FROM library.students WHERE student_name like @student or student_surname like @student or  student_email like @student or student_tc like @student", con);
                sql.Parameters.AddWithValue("@student", "%" + student + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql);
                 ds = new DataSet();
                
                adapter.Fill(ds);
              /*  DataTable datas = new DataTable();
                adapter.Fill(datas);
                BindingSource source = new BindingSource();
                source.DataSource = datas;
                dataGridView.DataSource = source;*/
                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                
                connectionClose(con);
            }
            
        }

        public static bool updateStudent(Student student, int id)

        {
            MySqlConnection con = openConnection();

            DataGridView dataGridViewSearch = new DataGridView();

            try
            {
                MySqlCommand com = new MySqlCommand("library.update_student", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@sPassword", student.getsPassword());
                com.Parameters.AddWithValue("@sName", student.getsName());
                com.Parameters.AddWithValue("@sSurname", student.getsSurname());
                com.Parameters.AddWithValue("@sLevel", student.getLevelID());
                com.Parameters.AddWithValue("@sEmail", student.getsEmail());
                com.Parameters.AddWithValue("@sPhone", student.getsPhone());
                com.Parameters.AddWithValue("@sTc", student.getsTc());
                com.Parameters.AddWithValue("@sAddress", student.getsAddress());
                com.Parameters.AddWithValue("@sId", id);

                com.ExecuteNonQuery();
                connectionClose(con);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
            finally
            {

                connectionClose(con);
            }

        }

        
        public static void getStudent(Label lab_name_d,Label lab_Borrow_d,DataGridView data_boroow)
        {
            MySqlConnection con = openConnection();

            try
            {
                if (con.State == ConnectionState.Closed)
                    MessageBox.Show("false");
                String str = "SELECT * FROM Student  WHERE sID = @sID";
                MySqlCommand com = new MySqlCommand(str, con);
                com.Parameters.AddWithValue("@sID", DAO.user.getuserEmail());
                MySqlDataReader reader = com.ExecuteReader();

                reader.Read();
                lab_name_d.Text = reader["sName"].ToString() + " " + reader["sSurname"].ToString();
                lab_Borrow_d.Text = Convert.ToString(reader["book_count"]);
                reader.Close();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT borrowDate, returnDate, DATEDIFF(DAY, borrowDate, returnDate) AS daysOfDelay FROM Borrow", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Borrow");
                data_boroow.DataSource = ds.Tables["Borrow"];

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public static void delete(string table_name, int id) {
            MySqlConnection con = openConnection();

            try
            {
                MySqlCommand com = new MySqlCommand("library.deletes", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@tName", table_name);
                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connectionClose(con);
            }
           

        }

        public static bool isExists(int bid, int stuid) {
            MySqlConnection con = openConnection();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM library.borrow WHERE book_id = @bID AND student_id  = @stuID", con);
            sql.Parameters.AddWithValue("@bID", bid);
            sql.Parameters.AddWithValue("@stuID", stuid);
            MySqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            else {
                reader.Close();
                return false;
            }

        } 
        public static MySqlConnection openConnection()
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            try
            {
                con.Open();
                return con;

            }
            catch (Exception e)
            {

                throw;
            }

        }

     
        
    }
}
