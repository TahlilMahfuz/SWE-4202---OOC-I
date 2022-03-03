using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_information
{
    internal class Teacher:Staff
    {
        public string subject, publication;

        public Teacher(int code, string name, string s,string p):base(code,name)
        {
            subject = s;
            publication = p;
        }

        public override string whoami()
        {
            return "I am a Teacher-staff";
        }
    }
}
