using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern2.Composite
{
    public class Program
    {
        public static void Main()
        {
            Commander topGeneral = new Commander("Dobry Djurov", "General of the Army");

            var subGeneralFirst = new Commander("Ivan Petrov", "Lieutenant General");
            var subGeneralSecond = new Commander("Georgy Ivanov", "Lieutenant General");

            topGeneral.AddSubordinate(subGeneralFirst);
            topGeneral.AddSubordinate(subGeneralSecond);

            Subordinate privateFirst = new Subordinate("Pesho Goshov", "Private");
            Subordinate privateSecond = new Subordinate("Tosho Peshov", "Private");
            Subordinate privateWounded = new Subordinate("Dimo Todorov", "Private");


            subGeneralFirst.AddSubordinate(privateFirst);
            subGeneralFirst.AddSubordinate(privateSecond);
            subGeneralFirst.AddSubordinate(privateWounded);

            Subordinate privateThird = new Subordinate("Sasho Ivanov", "Private");
            Subordinate privateFourth = new Subordinate("Joro Dimitrov", "Private");

            subGeneralSecond.AddSubordinate(privateThird);
            subGeneralSecond.AddSubordinate(privateFourth);

            topGeneral.Display(1);

            Console.WriteLine(new string('*', 30) + " The battle starts " + new string('*', 30));

            Console.WriteLine("The soldier: " + privateWounded.ToString() + " has been wounded and is sent to hospital");
            subGeneralFirst.RemoveSubordinate(privateWounded);

            topGeneral.Display(1);
        }
    }
}
