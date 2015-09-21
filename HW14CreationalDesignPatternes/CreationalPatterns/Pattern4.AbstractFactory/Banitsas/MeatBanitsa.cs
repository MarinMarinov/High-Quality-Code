using System.Collections.Generic;
using System.Text;

namespace Pattern4.AbstractFactory.Banitsas
{
    public class MeatBanitsa : Banitsa
    {
        private readonly string producer;

        public MeatBanitsa(IEnumerable<string> ingredients, string producer)
            : base(ingredients)
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
            info.AppendLine("Banitsa type: Banitsa with meat");
            info.AppendLine("Ingredients: " + string.Join(", ", this.Ingredients));

            return info.ToString();
        }
    }
}
