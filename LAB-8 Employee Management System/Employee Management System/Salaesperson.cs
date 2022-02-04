
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Salaesperson:Employee
    {
        public override string CountSalary(string s,int n)
        {
            int salary = Convert.ToInt32(s);
            string slry = Convert.ToString(salary + (salary * 10*n) / 100);
            return slry;
        }
    }
}
