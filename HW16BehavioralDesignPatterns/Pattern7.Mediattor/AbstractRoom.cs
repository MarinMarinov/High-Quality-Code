using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7.Mediattor
{
    /// <summary>
    /// The 'Mediator' abstraction
    /// </summary>
    public abstract class AbstractRoom
    {
        public abstract void Register(Chatter chatter);

        public abstract void Send(string from, string to, string message);

        public abstract void SendToAll(string from, string message);
    }
}
