using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern6.Observer
{
    public interface IObserver
    {
        void Update(River river);
    }
}
