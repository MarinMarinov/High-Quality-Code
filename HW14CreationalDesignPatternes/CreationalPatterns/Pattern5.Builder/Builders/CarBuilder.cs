namespace Pattern5.Builder.Builders
{
    public class CarBuilder : IVehicleBuilder
    {
        public CarBuilder()
        {
            this.Vehicle = new Vehicle("Car");
        }

        public Vehicle Vehicle { get; set; }

        public void BuildFrame()
        {
            this.Vehicle["frame"] = "steel car frame";
        }

        public void BuildEngine()
        {
            this.Vehicle["engine"] = "2500 diezel engine";
        }

        public void BuildWheels()
        {
            this.Vehicle["wheels"] = "4 wheels";
        }

        public void BuildDoors()
        {
            this.Vehicle["doors"] = "5 doors";
        }
    }
}