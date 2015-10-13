using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern8.Memento
{
    class Program
    {
        static void Main()
        {
            var personData = new AddressTemplate { Name = "Jordanka Hristova", Phone = "+359888123456", Address = "Sofia, Iztok, bl.3" };
            personData.Show();

            // Store internal state
            var memory = new Caretaker();
            Console.WriteLine("Saving object state... \n");
            memory.Memento = personData.SaveMemento();

            // Continue changing originator
            Console.WriteLine("\nChanging object state...");
            personData.Name = "Bogdan Tomov";
            personData.Phone = "+359898342313";
            personData.Address = "Plovidv, Trakia, bl.5";
            personData.Show();


            // Restore saved state
            Console.WriteLine("\nRestoring object state ...");
            personData.RestoreMemento(memory.Memento);
            personData.Show();
        }
    }
}
