using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_information
{
    internal class Staff
    {
        public int code;
        public string name;

        public Staff(int c,string n)
        {
            code = c;
            name = n;
        }

        public virtual string whoami()
        {
            return "i am a staff";
        }
    }
}
