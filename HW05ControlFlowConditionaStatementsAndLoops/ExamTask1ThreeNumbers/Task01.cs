using System;

class Program
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC = double.Parse(Console.ReadLine());

        double biggestNumber = numberA;
        double smallestNumber = numberC;

        if (numberB > biggestNumber)
        {
            biggestNumber = numberB;
        }

        if (numberC > biggestNumber)
        {
            biggestNumber = numberC;
        }

        Console.WriteLine(biggestNumber);

        if (numberA < smallestNumber)
        {
            smallestNumber = numberA;
        }

        if (numberB < smallestNumber)
        {
            smallestNumber = numberB;
        }

        Console.WriteLine(smallestNumber);

        double sum = numberA + numberB + numberC;
        double devidedSum = sum / 3;
        Console.WriteLine("{0:0.00}", devidedSum);
    }
}
