using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_information
{
    internal class Typist:Staff
    {
        public string speed;

        public Typist(int c, string n,string speed):base(c,n)
        {
            this.speed = speed;
        }
        public override string whoami()
        {
            return "I am a typist-staff";
        }
    }
    
}
