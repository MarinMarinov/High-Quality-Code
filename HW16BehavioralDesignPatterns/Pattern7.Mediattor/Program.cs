using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7.Mediattor
{
    class Program
    {
        static void Main()
        {
            Chatter airbus = new Plane("Airbus 320");
            Chatter boeing = new Plane("Boeing 737");
            Chatter tupolev = new Plane("Tu 154");
            Chatter bell = new Helicopter("Bell 429");

            ChatRoom airTrafficControlTower = new ChatRoom();

            airTrafficControlTower.Register(airbus);
            airTrafficControlTower.Register(boeing);
            airTrafficControlTower.Register(tupolev);
            airTrafficControlTower.Register(bell);

            Console.WriteLine("A helicopter communicates with plane ----------------------------------------------");
            bell.SendMessage("Tu 154", "Hello guys, keep your altitude, I am right above you!");
            tupolev.SendMessage("Bell 429", "Get it, go ahead!");
            Console.WriteLine();

            Console.WriteLine("A plane speeks to everyone ----------------------------------------------------------");
            airbus.SendMessageToAll("I am READY for takeoff");
            Console.WriteLine();


            Console.WriteLine("The Control tower speeks to the Airbus 320 ------------------------------------------");
            airTrafficControlTower.Send("Control tower", "Airbus 320", "Airbus 320, you have CLEAR for takeoff");
            Console.WriteLine();


            Console.WriteLine("The Control tower speeks to all aircrafts ------------------------------------------");
            airTrafficControlTower.SendToAll("Control tower", "Everyone keeps the altitude!");
        }
    }
}
