using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern3.FlyWeight
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    /// 
    public class CharacterA : Character
    {
        public CharacterA()
        {
            this.Symbol = 'A';
            this.Height = 100;
            this.Width = 70;
            this.Ascent = 5;
            this.Descent = 0;
        }

        public override void Display(int pointSize)
        {
            Console.WriteLine("{0} (point size {1})", this.Symbol, pointSize);
        }
    }
}
