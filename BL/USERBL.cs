using System;
using System.Collections.Generic;
using System.Text;

namespace Manage.BL
{
    class USERBL
    {
        public string COMPLAINT;
        public int NUMBER;
        public string username;
        public string firstname;
        public string lastname;
        public string email;
        public long NIC;
        public string pass;
        public int age;
        public string gender;
        public string city;
        public long contact;
        public USERBL(string username, string firstname, string lastname, string email, long NIC, string pass, int age, string gender, string city, long contact)
        {
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.NIC = NIC;
            this.pass = pass;
            this.age = age;
            this.gender = gender;
            this.city = city;
            this.contact = contact;
    }
        public USERBL(string username,string pass)
        {
            this.username = username;
            this.pass = pass;
        }

        public USERBL(string COMP ,int NUMBER )
        {
            this.COMPLAINT = COMP;
            this.NUMBER = NUMBER;
        }
    
    }
}
