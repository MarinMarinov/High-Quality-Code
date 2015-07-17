namespace _02.IfStatementsRefactoring
{
    using System;

    class TheMain
    {
        static void Main(string[] args)
        {
            // First example
            /*
            Potato potato;
            //... 
            if (potato != null)
                if (!potato.HasNotBeenPeeled && !potato.IsRotten)
                    Cook(potato);
             */

            Potato potato = new Potato();

            if (potato != null)
            {
                bool isNotPeeled = !potato.IsPeeled;
                bool isNotRotten = !potato.IsRotten;

                if (isNotPeeled && isNotRotten)
                {
                    Cook(potato);
                }
            }

            // Second example
            /*
            if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            {
                VisitCell();
            }
            */

            const int MinX = 0;
            const int MaxX = 10;
            const int MinY = 5;
            const int MaxY = 20;

            bool mustVisitCell = true;

            int x = 4;
            int y = 8;

            bool isInRangeX = InRange(x, MinX, MaxX);
            bool isInRangeY = InRange(y, MinY, MaxY);

            if (isInRangeX && isInRangeY && mustVisitCell)
            {
                Console.WriteLine("The Cell has just been visited");
            }

        }

        public static bool InRange(int variable, int min, int max)
        {
            bool isInRange = false;

            if (min < variable && variable < max)
            {
                isInRange = true;
            }

            return isInRange;
        }

        private static void Cook(Potato potato)
        {
            Console.WriteLine("This {0} has been cooked", potato.GetType().Name);
        }
    }
}
