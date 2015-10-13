using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern5.Command
{
    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    public class Invoker
    {
        private readonly Calculator calculator = new Calculator();
        private readonly List<ICommand> commands = new List<ICommand>();
        private int currentCommandIndex;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            for (int i = 0; i < levels; i++)
            {
                if (this.currentCommandIndex < this.commands.Count - 1)
                {
                    var command = this.commands[this.currentCommandIndex++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            for (int i = 0; i < levels; i++)
            {
                if (this.currentCommandIndex > 0)
                {
                    var command = this.commands[--this.currentCommandIndex];
                    command.UnExecute();
                }
            }
        }

        public void Compute(char theOperator, int operand)
        {
            ICommand command = new CalculatorCommand(this.calculator, theOperator, operand);
            command.Execute();

            this.commands.Add(command);
            this.currentCommandIndex++;
        }
    }
}
