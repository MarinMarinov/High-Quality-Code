using System.Collections.Generic;
using System.Text;

namespace Pattern4.AbstractFactory.Banitsas
{
    public class CheeseBanitsa : Banitsa
    {
        private string producer;

        public CheeseBanitsa(IEnumerable<string> ingredients, string producer):
            base(ingredients)
        {
            this.producer = producer;
        }

        protected override string Producer
        {
            get
            {
                return this.producer;
            }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Banitsa company name: " + this.Producer);
            info.AppendLine("Banitsa type: Banitsa with cheese");
            info.AppendLine("Ingredients: " + string.Join(", ", this.Ingredients));

            return info.ToString();
        }
    }
}
