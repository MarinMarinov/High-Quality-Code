using Pattern4.AbstractFactory.Banitsas;
using System.Collections.Generic;

namespace Pattern4.AbstractFactory.Factories
{
    public class HomeMadeBanitsaCompany : IFactory
    {
        private const string Name = "Baba Gitza Home made Banitsa";

        public CheeseBanitsa MakeCheeseBanitsa()
        {
            IEnumerable<string> ingredients = new List<string>{
                "home made eggs", "genuine milk", "home made cheese", "home made butter"
            };

            CheeseBanitsa cheeseBanitsa = new CheeseBanitsa(ingredients, Name);

            return cheeseBanitsa;
        }

        public MeatBanitsa MakeMeatBanitsa()
        {
            IEnumerable<string> ingredients = new List<string>{
                "meat from home grown animals", "home made eggs", "home made onion", "home made butter"
            };

            MeatBanitsa meatBanitsa = new MeatBanitsa(ingredients, Name);

            return meatBanitsa;
        }
    }
}
