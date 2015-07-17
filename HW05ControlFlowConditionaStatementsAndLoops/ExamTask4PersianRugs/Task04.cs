using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        // According to the Task, D value can be bigger than N value, so we need to check for this case
        if (d >= n)
        {
            d = n - 1;
        }

        // Drawing the Top part of the rug -----------------------------------------------------------------
        int topCounter = 0;
        int row = 1;
        int upperTopSpaces = d;
        int upperTopSharps = 0;
        int topDots = (2 * n) - (2 * d) - 3;

        for (int i = 0; i < n - d - 1; i++)
        {
            Console.Write(new string('#', upperTopSharps));
            Console.Write(new string('\\', 1));
            Console.Write(new string(' ', upperTopSpaces));
            Console.Write(new string('\\', 1));
            Console.Write(new string('.', topDots));
            Console.Write(new string('/', 1));
            Console.Write(new string(' ', upperTopSpaces));
            Console.Write(new string('/', 1));
            Console.WriteLine(new string('#', upperTopSharps));
            upperTopSharps++;
            topDots -= 2;
            row++;
            topCounter++;
        }

        int lowerTopSpaces = ((2 * n) + 1) - (2 * row);
        int lowerTopSharps = upperTopSharps;

        for (int i = n - d - 1; i < n; i++)
        {
            Console.Write(new string('#', lowerTopSharps));
            Console.Write(new string('\\', 1));
            Console.Write(new string(' ', lowerTopSpaces));
            Console.Write(new string('/', 1));
            Console.WriteLine(new string('#', lowerTopSharps));
            lowerTopSharps++;
            lowerTopSpaces -= 2;
            topCounter++;
        }

        // Drawing the middle line of the rug ------------------------------------------------------
        Console.Write(new string('#', n));
        Console.Write(new string('X', 1));
        Console.WriteLine(new string('#', n));

        // Drawing the Bottom(under the middle line) part of the rug -------------------------------
        int upperBottomSpaces = 1;
        int upperBottomSharps = n - 1;
        int bottomCounter = 0;

        for (int i = n + 2; i < n + 2 + d + 1; i++)
        {
            Console.Write(new string('#', upperBottomSharps));
            Console.Write(new string('/', 1));
            Console.Write(new string(' ', upperBottomSpaces));
            Console.Write(new string('\\', 1));
            Console.WriteLine(new string('#', upperBottomSharps));
            upperBottomSharps--;
            upperBottomSpaces += 2;
            bottomCounter++;
        }

        int firstBottomSpaces = d;
        int firstBottomSharps = n - 1 - bottomCounter;
        int bottomDots = 1;

        for (int i = n + 2 + d + 1; i <= (2 * n) + 1; i++)
        {
            Console.Write(new string('#', firstBottomSharps));
            Console.Write(new string('/', 1));
            Console.Write(new string(' ', firstBottomSpaces));
            Console.Write(new string('/', 1));
            Console.Write(new string('.', bottomDots));
            Console.Write(new string('\\', 1));
            Console.Write(new string(' ', firstBottomSpaces));
            Console.Write(new string('\\', 1));
            Console.WriteLine(new string('#', firstBottomSharps));
            firstBottomSharps--;
            bottomDots += 2;
        }
    }
}