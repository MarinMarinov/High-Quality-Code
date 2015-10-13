using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern6.Observer
{
    public class RuseObserver : IObserver
    {
        public void Update(River river)
        {
            Console.WriteLine("Notification from Ruse Observer Station of {0} river. Water level change to {1} centimetres",
                river.Name, river.WaterLevel);
        }
    }
}
