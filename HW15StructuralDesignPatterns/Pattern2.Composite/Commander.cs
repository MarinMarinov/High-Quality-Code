using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern2.Composite
{
    public class Commander : PersonComponent
    {
        private readonly ICollection<PersonComponent> subordinates;

        public Commander(string name, string type)
            : base(name, type)
        {
            this.subordinates = new List<PersonComponent>();
        }

        public void AddSubordinate(PersonComponent subordinate)
        {
            this.subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(PersonComponent subordinate)
        {
            this.subordinates.Remove(subordinate);
        }

        public override void Display(int tab)
        {
            Console.WriteLine(new string('-', tab) + string.Format("Name: {0}, Type: {1}", this.Name, this.Type));

            foreach (PersonComponent subordinate in this.subordinates)
            {
                subordinate.Display(tab + 4);
            }
        }
    }
}
