using Pattern5.Builder.Builders;
using System;

namespace Pattern5.Builder.Directors
{
    /// <summary>
    /// The 'Director' class
    /// Constructs an object using the Builder interface
    /// </summary>
    /// 
    public class VehicleDirector : IVehicleDirector
    {
        public void Construct(IVehicleBuilder builder)
        {
            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildWheels();
            builder.BuildDoors();
        }
    }
}
