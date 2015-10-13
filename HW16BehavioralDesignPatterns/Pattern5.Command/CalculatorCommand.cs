using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern5.Command
{
    public class CalculatorCommand : ICommand
    {
        private readonly Calculator calculator;
        private char theOperator;
        private int operand;

        public CalculatorCommand(Calculator calculator, char theOperator, int operand)
        {
            this.calculator = calculator;
            this.Operator = theOperator;
            this.Operand = operand;
        }

        public char Operator
        {
            get { return this.theOperator; }
            private set { this.theOperator = value; }
        }

        public int Operand
        {
            get { return this.operand;  }
            private set { this.operand = value; }
        }

        public void Execute()
        {
            this.calculator.Operation(this.Operator, this.Operand);
        }

        public void UnExecute()
        {
            char undoneOperator = Undo(this.Operator);
            this.calculator.Operation(undoneOperator, this.Operand);
        }

        private static char Undo(char operatorToUndo)
        {
            switch (operatorToUndo)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operator");
            }
        }
    }
}
