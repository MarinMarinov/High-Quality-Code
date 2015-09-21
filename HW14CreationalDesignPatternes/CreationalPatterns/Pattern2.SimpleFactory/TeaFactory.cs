using System;

namespace Pattern2.SimpleFactory
{
    public class TeaFactory
    {
        public Tea GetTea(TeaType herb, TeaAmount watter)
        {
            switch (herb)
            {
                case TeaType.Black:
                    return new Tea(TeaType.Black.ToString(), (int)watter);
                case TeaType.Cammomile:
                    return new Tea(TeaType.Cammomile.ToString(), (int)watter);
                case TeaType.Mint:
                    return new Tea(TeaType.Mint.ToString(), (int)watter);
                case TeaType.Thyme:
                    return new Tea(TeaType.Thyme.ToString(), (int)watter);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
