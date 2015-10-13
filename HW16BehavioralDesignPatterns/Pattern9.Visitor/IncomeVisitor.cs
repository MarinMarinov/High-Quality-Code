using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern9.Visitor
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    public class IncomeVisitor : IVisitor
    {
        private const decimal Increment = 1.1m;

        public void Visit(AbstractLector lector)
        {
            if (lector != null)
            {
                decimal currentIncome = lector.Income;
                lector.Income *= Increment;
                Console.WriteLine("{0} {1}'s income was {2} and has been changed to {3:F2}!",
                    lector.GetType().Name, lector.Name, currentIncome, lector.Income);
            }
        }
    }
}
