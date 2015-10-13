using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7.Mediattor
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    public class ChatRoom : AbstractRoom
    {
        private readonly Dictionary<string, Chatter> chatters = new Dictionary<string, Chatter>();


        public override void Register(Chatter chatter)
        {
            if (!this.chatters.ContainsValue(chatter))
            {
                this.chatters[chatter.Name] = chatter;
            }

            chatter.ChatRoom = this;
        }

        public override void Send(string from, string to, string message)
        {
            Chatter reciever = this.chatters[to];

            if (reciever != null)
            {
                reciever.Receive(from, message);
            }
        }

        public override void SendToAll(string from, string message)
        {
            foreach (var item in this.chatters) // what is the type of chatter
            {
                if (item.Key != from)
                {
                    item.Value.Receive(from, message);
                }
            }
        }
    }
}
