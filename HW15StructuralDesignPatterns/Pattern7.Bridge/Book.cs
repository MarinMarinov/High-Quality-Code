using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7.Bridge
{
    internal class Book : ScriptAbstraction
    {
        public Book(IFormatter formatter)
            : base(formatter)
        {
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Text { get; set; }

        public override void Print()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(this.formatter.Format("Title", this.Title));
            Console.WriteLine(this.formatter.Format("Author", this.Author));
            Console.WriteLine(this.formatter.Format("Text", this.Text));
            Console.WriteLine("-------------------");
        }
    }
}
