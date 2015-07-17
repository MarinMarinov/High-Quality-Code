namespace CohesionAndCoupling
{
    using System;
    
    public class Parallelepiped
    {
        private double width;
        private double height;
        private double depth;
        
        public Parallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
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
                    throw new ArgumentException("Parallelepiped width must be positive number");
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
                    throw new ArgumentException("Parallelepiped height must be positive number");
                }

                this.height = value; 
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Parallelepiped depth must be positive number");
                }

                this.depth = value;
            }
        }

        public double Volume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double DiagonalXYZ()
        {
            double distance = DistanceCalculator.CalculateDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double DiagonalXY()
        {
            double distance = DistanceCalculator.CalculateDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double DiagonalXZ()
        {
            double distance = DistanceCalculator.CalculateDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double DiagonalYZ()
        {
            double distance = DistanceCalculator.CalculateDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }

        public override string ToString()
        {
            return string.Format("Parallelepiped width = {0}, height = {1}, depth = {2}", this.Width, this.Height, this.Depth);
        }
    }
}