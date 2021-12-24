using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_Extended
{
    internal class User
    {
        public string UserID;
        public string UserName;
        public string Contact;
        public string Address;
        
        public User(string userid,string username,string contact,string adderss)
        {
            UserID = userid;
            UserName = username;
            Contact = contact;
            Address = adderss;
        }
    }
}
