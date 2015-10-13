using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7.Mediattor
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class Helicopter : Chatter
    {
        public Helicopter(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            base.Receive(from, message);
        }
    }
}
