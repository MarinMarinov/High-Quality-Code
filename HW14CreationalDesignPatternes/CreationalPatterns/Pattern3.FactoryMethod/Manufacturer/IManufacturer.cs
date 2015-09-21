namespace Pattern3.FactoryMethod.Manufacturer
{
    using Pattern3.FactoryMethod.Products;

    public interface IManufacturer
    {
        Car MakeCar();
    }
}
