using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class Finance
    {
        private int TotalSold;

        public int GetTotalSold()
        {
            return this.TotalSold;
        }
        public void SetTotalSold(int value)
        {
            this.TotalSold = value;
        }
        public void SetTotalSold()
        {
            this.TotalSold = 0;
        }
    }
}
