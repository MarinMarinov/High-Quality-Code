namespace Task03CompareAdvancedMaths
{
    using System;

    public class TestStarter
    {
        private const float FloatTester = 100.001f;
        private const double DoubleTester = 100.001;
        private const decimal DecimalTester = 1.0M;

        public static void Main(string[] args)
        {
            Console.WriteLine("------------- Operation Natural Logarithm tests ------------");
            
            Tester.OperateFloat(FloatTester, Operation.NaturalLogarithm);
            Tester.OperateDouble(DoubleTester, Operation.NaturalLogarithm);
            Tester.OperateDecimal(DecimalTester, Operation.NaturalLogarithm);

            Console.WriteLine();
            Console.WriteLine("------------- Operation Sinus tests ------------");

            
            Tester.OperateFloat(FloatTester, Operation.Sinus);
            Tester.OperateDouble(DoubleTester, Operation.Sinus);
            Tester.OperateDecimal(DecimalTester, Operation.Sinus);

            Console.WriteLine();
            Console.WriteLine("------------- Operation Square Root tests ------------");
            
            Tester.OperateFloat(FloatTester, Operation.SquareRoot);
            Tester.OperateDouble(DoubleTester, Operation.SquareRoot);
            Tester.OperateDecimal(DecimalTester, Operation.SquareRoot);


            Console.WriteLine();
            Console.WriteLine("Well, functions doesn't work very fast with decimal numbers :)");
        }
    }
}