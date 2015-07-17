namespace Abstraction
{
    using System;
    
    public class Circle : IFigureCalculator
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Circle radius must be positive number");
                }

                this.radius = value;
            }
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalculateArea()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
