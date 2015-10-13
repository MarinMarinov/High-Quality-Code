using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1.ChainOfResponsibility
{
    class ExecutiveDirector : AbstractApprover
    {
        public override void ProcessRequest(Order order)
        {
            if (order.Amount < 10000)
            {
                Console.WriteLine("{0} approved order #{1}, for amount of {2}, purpose {3}",
                    this.GetType().Name, order.Number, order.Amount, order.Purpose);
            }
            else if (order.Amount != null)
            {
                Console.WriteLine("The amount is exceeding 10 000 units! Please, wait for our special offer!");
            }
            else
            {
                Console.WriteLine("Your order is invalid");
            }
        }
    }
}
