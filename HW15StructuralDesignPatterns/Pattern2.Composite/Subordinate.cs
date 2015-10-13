using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern2.Composite
{
    public class Subordinate : PersonComponent
    {
        public Subordinate(string name, string type)
            : base(name, type)
        {
        }

        public override void Display(int tab)
        {
            Console.WriteLine(new string('-', tab) + string.Format("Name: {0}, Type: {1}", this.Name, this.Type));
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Type: {1}", this.Name, this.Type);
        }
    }
}
