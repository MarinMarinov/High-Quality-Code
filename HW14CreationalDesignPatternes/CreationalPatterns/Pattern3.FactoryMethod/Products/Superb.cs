namespace Pattern3.FactoryMethod.Products
{
    using System;

    class Superb:Car
    {
        public override void Start()
        {
            Console.WriteLine("Superb starts its engine");
        }
    }
}