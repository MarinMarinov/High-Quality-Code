namespace Abstraction
{
    using System;
    
    public class Rectangle : IFigureCalculator
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Rectangle width must be positive number");
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
                if (value <= 0)
                {
                    throw new ArgumentException("Rectangle width must be positive number");
                }

                this.height = value;
            }
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public double CalculateArea()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}