namespace Pattern5.Builder.Builders
{
    public class MotorbikeBuilder : IVehicleBuilder
    {
        public MotorbikeBuilder()
        {
            this.Vehicle = new Vehicle("Motorbike");
        }

        public Vehicle Vehicle { get; set; }

        public void BuildFrame()
        {
            this.Vehicle["frame"] = "alloy bike frame";
        }

        public void BuildEngine()
        {
            this.Vehicle["engine"] = "250cc two-stroke engine";
        }

        public void BuildWheels()
        {
            this.Vehicle["wheels"] = "2 wheels";
        }

        public void BuildDoors()
        {
            this.Vehicle["doors"] = "0 doors";
        }         
    }
}
