using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7.Bridge
{
    class Program
    {
        static void Main()
        {
            List<ScriptAbstraction> documents = new List<ScriptAbstraction>();

            StandartFormatter formatter = new StandartFormatter();
            BackwordsFormatter backwordsFormatter = new BackwordsFormatter();


            Book book = new Book(formatter);
            book.Author = "Ernest Hemingway";
            book.Title = "For Whom the Bell Tolls";
            book.Text = "He lay flat on the brown, pine-needled floor of the forest, his chin on his folded arms, and"
                + "\n high overhead the wind blew in the tops of the pine trees. The mountainside sloped gently where he lay;"
                + "\n but below it was steep and he could see the dark of the oiled road winding through the pass."
                + "\n There was a stream alongside the road and far down the pass he saw a mill beside the stream and the falling"
                + "\n water of the dam, white in the summer sunlight.";

            book.Print();

            Newspaper newspaper = new Newspaper(backwordsFormatter)
            {
                Name = "The Guardian",
                Publisher = "Guardian News and Media Limited",
                Text = "European governments have pushed through by majority vote a deal to share 120,000 refugees between most of the countries of the EU",
            };

            newspaper.Print();
        }
    }
}
