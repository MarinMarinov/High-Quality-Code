using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1.ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            AbstractApprover petar = new Menager();
            AbstractApprover dimitar = new DivisionManager();
            AbstractApprover ivan = new ExecutiveDirector();

            //set successors
            petar.SetSuccessor(dimitar);
            dimitar.SetSuccessor(ivan);

            Order smallOrder = new Order(1, 999.99, "Water delivering");
            petar.ProcessRequest(smallOrder);

            Order mediumOrder = new Order(2, 1001, "Fuel delivering");
            petar.ProcessRequest(mediumOrder);

            Order bigOrder = new Order(3, 9999, "Oil delivering");
            petar.ProcessRequest(bigOrder);

            Order specialOrder = new Order(4, 10001, "Tanker delivering");
            petar.ProcessRequest(specialOrder);

            Order nullOrder = new Order(5, null, "Test null order");
            petar.ProcessRequest(nullOrder);
        }
    }
}
