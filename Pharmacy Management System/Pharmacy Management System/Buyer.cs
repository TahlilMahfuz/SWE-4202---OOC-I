using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class Buyer
    {
        private string M_name;
        private string M_quantity;

        public string GetM_name()
        {
            return this.M_name;
        }
        public void SetM_name(string value)
        {
            this.M_name = value;
        }

        public string GetM_quantity()
        {
            return this.M_quantity;
        }
        public void SetM_quantity(string value)
        {
            this.M_quantity = value;
        }
    }
}
