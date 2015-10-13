using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern6.Observer
{
     /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public class DanubeRiver : River
    {
        public DanubeRiver(string name, int waterLevel):base(name, waterLevel)
        {
        }
    }
}
