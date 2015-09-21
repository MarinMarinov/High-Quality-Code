namespace Pattern3.FactoryMethod.Manufacturer
{
    using Products;

    public class Audi: IManufacturer
    {
        public Car MakeCar()
        {
            Car a8 = new A8 { Color = "Red", Doors = 5, Gear = GearType.Automatic, Name = "Audi A8" };
            return a8;
        }
    }
}
