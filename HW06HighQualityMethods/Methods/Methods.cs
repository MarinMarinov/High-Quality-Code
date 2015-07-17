namespace Methods
{
    using System;
    
    public class Methods
    {
        public static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(DigitAsWord(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsFloatNumber(1.3);
            PrintNumberAsPercentage(0.75);
            PrintRightAlignedNumber(2.30);

            bool horizontal = CheckForHorizontalPosition(3, 3);
            bool vertical = CheckForVerticalPosition(-1, 2.5);
            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", "From Sofia", "17.03.1992");

            Student stella = new Student("Stella", "Markova", "From Vidin, gamer, high results", "03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
        
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Each side of triangle must be positive number");
            }

            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

            return area;
        }

        public static string DigitAsWord(int number)
        {
            string digitAsWord = string.Empty;

            switch (number)
            {
                case 0: digitAsWord = "zero"; break;
                case 1: digitAsWord = "one"; break;
                case 2: digitAsWord = "two"; break;
                case 3: digitAsWord = "three"; break;
                case 4: digitAsWord = "four"; break;
                case 5: digitAsWord = "five"; break;
                case 6: digitAsWord = "six"; break;
                case 7: digitAsWord = "seven"; break;
                case 8: digitAsWord = "eight"; break;
                case 9: digitAsWord = "nine"; break;
                default: throw new ArgumentException("Invalid digit");
            }

            return digitAsWord;
        }

        public static int FindMax(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Elements cannot be null or empty array");
            }

            int maxNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }

        public static void PrintAsFloatNumber(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintNumberAsPercentage(double number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintRightAlignedNumber(double number)
        {
            Console.WriteLine("{0,8}", number);
        }

        public static bool CheckForHorizontalPosition(double x1, double x2)
        {
            bool isHorizontal = false;

            if (x1 == x2)
            {
                isHorizontal = true;
            }

            return isHorizontal;
        }

        public static bool CheckForVerticalPosition(double y1, double y2)
        {
            bool isVertical = false;

            if (y1 == y2)
            {
                isVertical = true;
            }

            return isVertical;
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }
    }
}
