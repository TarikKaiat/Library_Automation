using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation
{
    class User
    {

        private string userEmail;
        private string password;
        

        public void setuserEmail(string userEmail)
        {
            this.userEmail = userEmail;
        }

        public string getuserEmail()
        {
            return userEmail;
        }

        public void setPassword(string pwd)
        {
            password = pwd;
        }

        public string getPassword()
        {
            return password;
        }



    }
}
