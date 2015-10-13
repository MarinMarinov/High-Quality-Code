using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7.Mediattor
{
    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    public abstract class Chatter
    {
        private readonly string name;
        private AbstractRoom chatRoom;

        protected Chatter(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public AbstractRoom ChatRoom
        {
            get { return this.chatRoom; }
            set { this.chatRoom = value; }
        }

        public void SendMessage(string to, string message)
        {
            this.ChatRoom.Send(this.Name, to, message);
        }

        public void SendMessageToAll(string message)
        {
            this.ChatRoom.SendToAll(this.Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} send message to {1}: '{2}'", from, this.Name, message);
        }
    }
}
