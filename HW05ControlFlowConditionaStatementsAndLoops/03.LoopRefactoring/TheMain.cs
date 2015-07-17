namespace _03.LoopRefactoring
{
    using System;
    
    class TheMain
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            for (i = 0; i < 100; )
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        i = 666;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine(array[i]);
                    i++;
                }
            }
            // More code here
            if (i == 666)
            {
                Console.WriteLine("Value Found");
            }*/

            int[] array = new int[700];
            array[665] = 666;
            bool isFound = false;
            int expectedValue = 666;

            for (int i = 0; i < array.Length; i += 1)
            {
                Console.WriteLine(array[i]);
                if (array[i] == expectedValue)
                {
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }

            // More code here
        }
    }
}
