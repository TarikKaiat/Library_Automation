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
    public partial class Form_Student_Liste : Form
    {
        public Form_Student_Liste()
        {
            InitializeComponent();
        }

        private void Form_Student_Liste_Load(object sender, EventArgs e)
        {

        }



        private void txt_query_TextChanged(object sender, EventArgs e)
        {
            if (txt_query.Text != "")
            {
                data_liste.DataSource = DAO.searchStudent(txt_query.Text).Tables[0];
            }
            else {
                data_liste.DataSource = null;
            }
            
        }
    }
}
