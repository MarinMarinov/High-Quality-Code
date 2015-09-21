using Pattern4.AbstractFactory.Banitsas;
using Pattern4.AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern4.AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFactory sofiaCompany = new SofiaBanitsaCompany(); // Working with the abstraction(the interface)

            Banitsa sofiaCheese = sofiaCompany.MakeCheeseBanitsa(); // Working with the abstraction(the abstract class Banitsa)
            Console.WriteLine("Directly delivered banitsa: " + sofiaCheese);

            IFactory grandMother = new HomeMadeBanitsaCompany();

            DeliveryCompany delivererOfHomeMadeBanitsa = new DeliveryCompany(grandMother);

            Banitsa grandMaCheeseBanitsa = delivererOfHomeMadeBanitsa.DeliverCheeseBanitsa();
            Banitsa grandMaMeatBanitsa = delivererOfHomeMadeBanitsa.DeliverMeatBanitza();

            Console.WriteLine("Delivered true delivery company: " + grandMaCheeseBanitsa);
            Console.WriteLine("Delivered true delivery company: " + grandMaMeatBanitsa);
        }
    }
}
