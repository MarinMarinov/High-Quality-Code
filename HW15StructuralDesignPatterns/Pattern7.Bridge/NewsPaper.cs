using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7.Bridge
{
    internal class Newspaper : ScriptAbstraction
    {
        public Newspaper(IFormatter formatter)
            : base(formatter)
        {
        }

        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Text { get; set; }

        public override void Print()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(this.formatter.Format("Name", this.Name));
            Console.WriteLine(this.formatter.Format("Publisher", this.Publisher));
            Console.WriteLine(this.formatter.Format("Text ", this.Text));
            Console.WriteLine("-------------------");
        }
    }
}
