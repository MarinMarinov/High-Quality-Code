using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1.ChainOfResponsibility
{
    internal class Menager : AbstractApprover
    {
        public override void ProcessRequest(Order order)
        {
            if (order.Amount < 1000)
            {
                Console.WriteLine("{0} approved order #{1}, for amount of {2}, purpose {3}",
                    this.GetType().Name, order.Number, order.Amount, order.Purpose);
            }
            else if (order.Amount != null)
            {
                successor.ProcessRequest(order);
            }
            else
            {
                Console.WriteLine("Your order is invalid");
            }
        }
    }
}
