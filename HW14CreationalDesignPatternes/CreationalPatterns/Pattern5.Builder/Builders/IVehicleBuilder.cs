namespace Pattern5.Builder.Builders
{
    /// </summary>
    /// The 'Builder' interface, specifies an abstract interface for creating parts of a Product object
    /// Concrete builders define and keep track of the representations they create
    /// </summary>
    public interface IVehicleBuilder
    {
        Vehicle Vehicle { get; set; }

        void BuildFrame();

        void BuildEngine();

        void BuildWheels();

        void BuildDoors();
    }
}
