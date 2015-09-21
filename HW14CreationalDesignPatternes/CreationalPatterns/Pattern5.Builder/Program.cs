using Pattern5.Builder.Builders;
using Pattern5.Builder.Directors;

namespace Pattern5.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleDirector director = new VehicleDirector();

            IVehicleBuilder bikeBuilder = new MotorbikeBuilder();
            director.Construct(bikeBuilder);
            bikeBuilder.Vehicle.Show();

            IVehicleBuilder carBuilder = new CarBuilder();
            director.Construct(carBuilder);
            carBuilder.Vehicle.Show();
        }
    }
}
