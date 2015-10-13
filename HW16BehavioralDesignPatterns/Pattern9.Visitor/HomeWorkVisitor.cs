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
    public class HomeWorkVisitor : IVisitor
    {
        private const int days = 3;

        public void Visit(AbstractLector lector)
        {
            if (lector != null)
            {
                int currentDays = lector.WorkFromHomeDays;
                lector.WorkFromHomeDays += days;
                Console.WriteLine("{0} {1}'s working-from-home days was {2} and has been changed to {3}!",
                    lector.GetType().Name, lector.Name, currentDays, lector.WorkFromHomeDays);
            }
        }
    }
}