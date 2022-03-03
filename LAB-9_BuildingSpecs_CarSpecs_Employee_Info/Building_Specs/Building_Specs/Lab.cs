using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Specs
{
    internal class Lab
    {
        private string Lab_name;
        private string  LAB_Capacity;
        
        public string getLabName()
        {
            return Lab_name;
        }
        public void setLabName(string s)
        {
            Lab_name= s;
        }

        public string getCapacity()
        {
            return LAB_Capacity;
        }
        public void setCapacity(string c)
        {
            LAB_Capacity = c;
        }


    }
}
