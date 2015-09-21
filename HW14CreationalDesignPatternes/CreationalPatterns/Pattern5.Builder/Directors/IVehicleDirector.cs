using Pattern5.Builder.Builders;

namespace Pattern5.Builder.Directors
{
    public interface IVehicleDirector
    {
        void Construct(IVehicleBuilder builder);
    }
}
