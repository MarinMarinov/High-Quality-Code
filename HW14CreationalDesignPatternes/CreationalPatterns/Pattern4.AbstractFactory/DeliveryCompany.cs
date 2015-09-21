using Pattern4.AbstractFactory.Banitsas;
using Pattern4.AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern4.AbstractFactory
{
    /// <summary>
    /// This class is not part of the Abstract Factory implementation. It just gives us another functionallity;
    /// </summary>
    public class DeliveryCompany
    {
        private readonly IFactory factory;

        public DeliveryCompany(IFactory factory) // Constructor-injection(DIP principle)
        {
            this.factory = factory;
        }

        public CheeseBanitsa DeliverCheeseBanitsa()
        {
            return this.factory.MakeCheeseBanitsa();
        }

        public MeatBanitsa DeliverMeatBanitza()
        {
            return this.factory.MakeMeatBanitsa();
        }
    }
}
