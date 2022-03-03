using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_information
{
    internal class Regular:Typist
    {
        public Regular(int c, string n,string speed):base(c,n,speed)
        {

        }
        public override string whoami()
        {
            return "I am a Regular-Typist-Staff";
        }
    }
    
}
