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
    public partial class Frm_login : Form
    {
        private void log_in (byte i)
        {
            Form_Main_Panel panel = new Form_Main_Panel(i);
            panel.Show();
            this.Hide();
        }

        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //User user = DAO.user;
        /*  if ( ( txt_username.Text.Equals("") || txt_password.Text.Equals("") ) )
            {
                MessageBox.Show("Please Check your entered Id or password.");

            }

            else {
                DAO.user.setPassword(txt_password.Text);
                DAO.user.setuserEmail(txt_username.Text);

            }


            if (DAO.userLogin(DAO.user, 1) && radio_stu.Checked)
            {
                log_in(2);
            }
            else if (DAO.user.getuserEmail() == "ammarahmouni8@gmail.com" && DAO.userLogin(DAO.user, 2) && radio_person.Checked)
            {
                log_in(0);
            }
            else if (DAO.userLogin(DAO.user, 2) && radio_person.Checked)
            {
                log_in(1);
            }
            else if(!(txt_username.Text.Equals("")) && !(txt_password.Text.Equals("")))
            {
                MessageBox.Show("Please your entered Id or password is wrong.");
            }*/
           log_in(0);

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            radio_person.Checked = true;
        }


    }
}
