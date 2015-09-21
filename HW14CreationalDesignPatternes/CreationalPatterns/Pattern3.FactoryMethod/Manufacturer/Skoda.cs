namespace Pattern3.FactoryMethod.Manufacturer
{
    using Products;

    public class Skoda: IManufacturer
    {
        public Car MakeCar()
        {
            Car superb = new Superb { Color = "Black", Doors = 5, Gear = GearType.Manual, Name = "Skoda Superb"};

            return superb;
        }
    }
}
