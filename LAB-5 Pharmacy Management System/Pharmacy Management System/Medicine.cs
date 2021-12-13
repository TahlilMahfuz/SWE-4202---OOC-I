using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class Medicine
    {
        private string Name;
        private string Quantity;
        private string PricePerQuantity;

        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string value)
        {
            this.Name = value;
        }

        public string GetQuantity()
        {
            return this.Quantity;
        }
        public void SetQuantity(string value)
        {
            this.Quantity = value;
        }

        public string GetPricePerQuantity()
        {
            return this.PricePerQuantity;
        }
        public void SetPricePerQuantity(string value)
        {
            this.PricePerQuantity = value;
        }
    }
}
