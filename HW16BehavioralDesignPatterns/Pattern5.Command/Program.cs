using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern5.Command
{
    class Program
    {
        static void Main()
        {
            var calculator = new Calculator();
            CalculatorCommand command = new CalculatorCommand(calculator, '+', 5);

            command.Execute(); // Current value =   5 (following + 5)
            command.Execute(); // Current value =  10 (following + 5)
            command.UnExecute(); // Current value =   5 (following - 5)

            // using Invoker
            Invoker user = new Invoker();
                        
            user.Compute('+', 7);  // Current value =   7 (following + 7)
            user.Compute('-', 3);  // Current value =   4 (following - 3)
            user.Compute('*', 12); // Current value =  48 (following * 12)

            user.Undo(2);           // ---- Undo 2 levels
                                    //Current value =   4 (following / 12)
                                    //Current value =   7 (following + 3)

            user.Redo(1);           //---- Redo 1 levels
                                    // Current value =   4 (following - 3)

        }
    }
}
