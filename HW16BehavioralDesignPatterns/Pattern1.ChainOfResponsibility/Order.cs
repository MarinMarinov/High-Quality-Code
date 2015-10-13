using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1.ChainOfResponsibility
{
    public class Order
    {
        public Order(int number, double? amount, string purpose)
        {
            this.Number = number;
            this.Amount = amount;
            this.Purpose = purpose;
        }

        public int Number { get; set; }

        public double? Amount { get; set; }

        public string Purpose { get; set; }
    }
}
