using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation
{
    class Employee
    {
        private string ePassword;
        private string eName;
        private string eSurname;
        private string eStartdate;
        private string eEmail;
        private string ePhone;
        private string eTc;
        private string eAddress;
        private int eSalary;
        

        public string getePassword()
        {
            return ePassword;
        }

        public void setePassword(string ePassword)
        {
            this.ePassword = ePassword;
        }

        public string geteName()
        {
            return eName;
        }

        public void seteName(string eName)
        {
            this.eName = eName;
        }

        public string geteStartdate()
        {
            return eStartdate;
        }

        public void seteStartdate(string eStartdate)
        {
            this.eStartdate = eStartdate;
        }

        public int geteSalary()
        {
            return eSalary;
        }

        public void seteSalary(int eSalary)
        {
            this.eSalary = eSalary;
        }
        public string geteSurname()
        {
            return eSurname;
        }

        public void seteSurname(string eSurname)
        {
            this.eSurname = eSurname;
        }

        public string geteEmail()
        {
            return eEmail;
        }

        public void seteEmail(string eEmail)
        {
            this.eEmail = eEmail;
        }

        public string getePhone()
        {
            return ePhone;
        }

        public void setePhone(string ePhone)
        {
            this.ePhone = ePhone;
        }

        public string geteTc()
        {
            return eTc;
        }

        public void seteTc(string eTc)
        {
            this.eTc = eTc;
        }

        public string geteAddress()
        {
            return eAddress;
        }

        public void seteAddress(string eAddress)
        {
            this.eAddress = eAddress;
        }
    }
}
