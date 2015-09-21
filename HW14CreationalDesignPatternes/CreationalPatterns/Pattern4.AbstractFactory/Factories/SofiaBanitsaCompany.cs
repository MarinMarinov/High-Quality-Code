using Pattern4.AbstractFactory.Banitsas;
using System.Collections.Generic;

namespace Pattern4.AbstractFactory.Factories
{
    public class SofiaBanitsaCompany : IFactory
    {
        private const string Name = "Sofiiska Banitsa";

        public CheeseBanitsa MakeCheeseBanitsa()
        {
            IEnumerable<string> ingredients = new List<string>{
                "eggs", "milk", "cheese", "butter"
            };

            CheeseBanitsa cheeseBanitsa = new CheeseBanitsa(ingredients, Name); // TODO Why can't use the abstraction Banitsa

            return cheeseBanitsa;
        }

        public MeatBanitsa MakeMeatBanitsa()
        {
            IEnumerable<string> ingredients = new List<string>{
                "meat", "eggs", "onion"
            };

            MeatBanitsa meatBanitsa = new MeatBanitsa(ingredients, Name);

            return meatBanitsa;
        }
    }
}
