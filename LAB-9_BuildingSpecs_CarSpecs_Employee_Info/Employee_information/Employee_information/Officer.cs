using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_information
{
    internal class Officer : Staff
    {
        public string grade;

        public Officer(int c, string n,string g):base(c,n)
        {
            grade = n;
        }
        public override string whoami()
        {
            return "I am a Officer-staff";
        }
    }
    
}
