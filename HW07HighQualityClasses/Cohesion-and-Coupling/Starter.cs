namespace CohesionAndCoupling
{
    using System;

    public class Starter
    {
        public static void Main()
        {
            Console.WriteLine(GetFileName.Extension("example"));
            Console.WriteLine(GetFileName.Extension("example.pdf"));
            Console.WriteLine(GetFileName.Extension("example.new.pdf"));

            Console.WriteLine(GetFileName.Filename("example"));
            Console.WriteLine(GetFileName.Filename("example.pdf"));
            Console.WriteLine(GetFileName.Filename("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", DistanceCalculator.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", DistanceCalculator.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            Parallelepiped box = new Parallelepiped(12.6, 4.85, 3.87);

            Console.WriteLine(box.ToString());

            var boxVolume = box.Volume();
            var boxDiagonalXyz = box.DiagonalXYZ();
            var boxDiagonalXy = box.DiagonalXY();
            var boxDiagonalXz = box.DiagonalXZ();
            var boxDiagonalYz = box.DiagonalYZ();

            Console.WriteLine("Volume = {0:f2}", boxVolume);
            Console.WriteLine("Diagonal XYZ = {0:f2}", boxDiagonalXyz);
            Console.WriteLine("Diagonal XY = {0:f2}", boxDiagonalXy);
            Console.WriteLine("Diagonal XZ = {0:f2}", boxDiagonalXz);
            Console.WriteLine("Diagonal YZ = {0:f2}", boxDiagonalYz);
        }
    }
}
