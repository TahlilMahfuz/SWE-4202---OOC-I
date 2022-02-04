using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Employee
    {
        public string EmployeeID, Name, Designation, Contact, Date, Salary, Leaves;

        public virtual string CountSalary(string s,int n)
        {
            return s;
        }
    }
}
