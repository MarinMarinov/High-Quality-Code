namespace Task02CompareSimpleMathOperations
{
    using System;

    public class TestStarter
    {
        private const int IntTester = 1;
        private const long LongTester = 1L;
        private const float FloatTester = 1.0f;
        private const double DoubleTester = 1.0;
        private const decimal DecimalTester = 1.0M;

        public static void Main(string[] args)
        {
            Console.WriteLine("------------- Operation Add tests ------------");
            
            Tester.OperateInteger(IntTester, Operation.Add);
            Tester.OperateLong(LongTester, Operation.Add);
            Tester.OperateFloat(FloatTester, Operation.Add);
            Tester.OperateDouble(DoubleTester, Operation.Add);
            Tester.OperateDecimal(DecimalTester, Operation.Add);

            Console.WriteLine();
            Console.WriteLine("------------- Operation Divide tests ------------");

            Tester.OperateInteger(IntTester, Operation.Divide);
            Tester.OperateLong(LongTester, Operation.Divide);
            Tester.OperateFloat(FloatTester, Operation.Divide);
            Tester.OperateDouble(DoubleTester, Operation.Divide);
            Tester.OperateDecimal(DecimalTester, Operation.Divide);

            Console.WriteLine();
            Console.WriteLine("------------- Operation Increment tests ------------");

            Tester.OperateInteger(IntTester, Operation.Increment);
            Tester.OperateLong(LongTester, Operation.Increment);
            Tester.OperateFloat(FloatTester, Operation.Increment);
            Tester.OperateDouble(DoubleTester, Operation.Increment);
            Tester.OperateDecimal(DecimalTester, Operation.Increment);

            Console.WriteLine();
            Console.WriteLine("------------- Operation Multiply tests ------------");

            Tester.OperateInteger(IntTester, Operation.Multiply);
            Tester.OperateLong(LongTester, Operation.Multiply);
            Tester.OperateFloat(FloatTester, Operation.Multiply);
            Tester.OperateDouble(DoubleTester, Operation.Multiply);
            Tester.OperateDecimal(DecimalTester, Operation.Multiply);

            Console.WriteLine();
            Console.WriteLine("------------- Operation Subtract tests ------------");

            Tester.OperateInteger(IntTester, Operation.Subtract);
            Tester.OperateLong(LongTester, Operation.Subtract);
            Tester.OperateFloat(FloatTester, Operation.Subtract);
            Tester.OperateDouble(DoubleTester, Operation.Subtract);
            Tester.OperateDecimal(DecimalTester, Operation.Subtract);

            Console.WriteLine();
            Console.WriteLine("Well, the decimal numbers operations aren't the fastest things in the Universe :)");
        }
    }
}