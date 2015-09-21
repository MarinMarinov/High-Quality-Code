using System;

namespace Pattern6.Prototype
{
    class Program
    {
        static void Main()
        {
            Soldier marine = new Soldier("Marine", 190, "AK-47");
            //Soldier cannonier = new Soldier("Cannonier", 180, "RPG");

            Soldier marine2 = marine.Clone();
            marine2.Weapon = "Mauser";

            Console.WriteLine(marine.ToString());
            Console.WriteLine(marine2.ToString());
        }
    }
}
