using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_information
{
    internal class Casual:Typist
    {
        public string daily_wages;

        public Casual(int c, string n, string speed,string daily_wages) : base(c, n, speed)
        {
            this.daily_wages = daily_wages;
        }
        public override string whoami()
        {
            return "I am a casual-typist-staff";
        }
    }
    
}
