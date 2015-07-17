namespace ClassSizeInCSharp
{
    using System;

    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width value must be positive number");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height value must be positive number");
                }

                this.height = value;
            }
        }

        public static Figure GetRotatedFigure(Figure figure, double angleOfRotation)
        {
            double sinOfAngle = Math.Sin(angleOfRotation);
            double cosOfAngle = Math.Cos(angleOfRotation);

            double modulOfSinus = Math.Abs(sinOfAngle);
            double modulOfCosinus = Math.Abs(cosOfAngle);

            double rotatedFigureWidth = (modulOfCosinus * figure.width) + (modulOfSinus * figure.height);
            double rotatedFigureHeight = (modulOfSinus * figure.width) + (modulOfCosinus * figure.height);

            Figure rotatedFigure = new Figure(rotatedFigureWidth, rotatedFigureHeight);

            return rotatedFigure;            
        }
    }
}
