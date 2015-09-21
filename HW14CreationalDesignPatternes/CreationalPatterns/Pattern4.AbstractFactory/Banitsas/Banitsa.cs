using System.Collections.Generic;

namespace Pattern4.AbstractFactory.Banitsas
{
    public abstract class Banitsa
    {
        private readonly IList<string> ingredients;

        protected Banitsa(IEnumerable<string> ingredients)
        {
            this.ingredients = new List<string>(ingredients);
        }

        protected IList<string> Ingredients
        {
            get
            {
                return this.ingredients;
            }
        }

        protected abstract string Producer { get; }
    }
}
