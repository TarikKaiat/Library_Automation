using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation
{
    
    class Student
    {
        private string sPassword;
        private string sName;
        private string sSurname;
        private int levelID;
        private string sEmail;
        private string sPhone;
        private string sTc;
        private string sAddress;

        public Student()
        {

        }
        public string getsPassword()
        {
            return sPassword;
        }

        public void setsPassword(string sPassword)
        {
            this.sPassword = sPassword;
        }

        public string getsName()
        {
            return sName;
        }

        public void setsName(string sName)
        {
            this.sName = sName;
        }

        public string getsSurname()
        {
            return sSurname;
        }

        public void setsSurname(string sSurname)
        {
            this.sSurname = sSurname;
        }

        public int getLevelID()
        {
            return levelID;
        }

        public void setLevelID(int levelID)
        {
            this.levelID = levelID;
        }

        public string getsEmail()
        {
            return sEmail;
        }

        public void setsEmail(string sEmail)
        {
            this.sEmail = sEmail;
        }

        public string getsPhone()
        {
            return sPhone;
        }

        public void setsPhone(string sPhone)
        {
            this.sPhone = sPhone;
        }

        public string getsTc()
        {
            return sTc;
        }

        public void setsTc(string sTc)
        {
            this.sTc = sTc;
        }

        public string getsAddress()
        {
            return sAddress;
        }

        public void setsAddress(string sAddress)
        {
            this.sAddress = sAddress;
        }
    }
}
