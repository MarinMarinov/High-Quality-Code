using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern5.Command
{
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    public class Calculator
    {
        private decimal currentValue;

        public void Operation(char theOperator, int operand)
        {
            switch (theOperator)
            {
                case '+':
                    this.currentValue += operand;
                    break;
                case '-':
                    this.currentValue -= operand;
                    break;
                case '*':
                    this.currentValue *= operand;
                    break;
                case '/':
                    this.currentValue /= operand;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Illegal operator");
            }

            Console.WriteLine("Current value = {0,3} (following {1} {2})", this.currentValue, theOperator, operand);
        }
    }
}
