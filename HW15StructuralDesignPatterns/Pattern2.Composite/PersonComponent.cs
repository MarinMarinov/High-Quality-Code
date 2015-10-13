using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern2.Composite
{
    public abstract class PersonComponent
    {
        protected PersonComponent(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        protected string Name { get; private set; }

        protected string Type { get; private set; }

        public abstract void Display(int tab); 
    }
}
