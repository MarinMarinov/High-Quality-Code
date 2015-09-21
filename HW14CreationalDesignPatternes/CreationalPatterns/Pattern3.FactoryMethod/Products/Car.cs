namespace Pattern3.FactoryMethod.Products
{
    using System;
    using System.Text;

    public abstract class Car
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public GearType Gear { get; set; }

        public int Doors { get; set; }

        public abstract void Start();

        public void GetCarInfo()
        {
            StringBuilder carInfo = new StringBuilder();

            carInfo.AppendFormat("Car Name: " + this.Name);
            carInfo.AppendLine();
            carInfo.AppendFormat("Car Color: " + this.Color);
            carInfo.AppendLine();
            carInfo.AppendFormat("Car Gears type: " + this.Gear);
            carInfo.AppendLine();
            carInfo.AppendFormat("Car Doors number: " + this.Doors);
            carInfo.AppendLine();

            Console.WriteLine(carInfo.ToString());
        }
    }
}
