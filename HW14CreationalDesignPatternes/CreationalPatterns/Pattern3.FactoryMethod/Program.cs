using Pattern3.FactoryMethod.Manufacturer;
using Pattern3.FactoryMethod.Products;
using System;
using System.Configuration; // For the ConfigurationManager class. Need to inlcude reference in the References
using System.Reflection; // For the Assembly class

namespace Pattern3.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // direct invoking of the manufacturer class
            IManufacturer skodaManufacturer = new Skoda(); // also possible to make Skoda
            Car skodaCar = skodaManufacturer.MakeCar();
            skodaCar.GetCarInfo();
            skodaCar.Start();
            Console.WriteLine(new string('-', 60));

            // Keeping Dependency Inversion principle- using Constructor injection:

            GiveCar(new Audi());
            Console.WriteLine(new string('-', 60));

            GiveCar(new Skoda());
            Console.WriteLine(new string('-', 60));

            // !!!! USING REFLECTION

            Console.WriteLine("Using Reflection!!!!!!!!!!!!!!!!!!");
            var factoryClassName = ConfigurationManager.AppSettings["ManufacturerFactory"];
            var manufacturer =
                Assembly.GetExecutingAssembly()
                .CreateInstance(factoryClassName) as IManufacturer;
            GiveCar(manufacturer);
            Console.WriteLine(new string('-', 60));
        }

        private static void GiveCar(IManufacturer manufacturer) // Constructor injection
        {
            Car someCar = manufacturer.MakeCar();
            someCar.GetCarInfo();
            someCar.Start();
        }
    }
}
