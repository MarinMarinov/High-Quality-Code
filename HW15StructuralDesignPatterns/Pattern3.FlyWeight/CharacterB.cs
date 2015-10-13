using System;

namespace Pattern3.FlyWeight
{
    class CharacterB : Character
    {
        public CharacterB()
        {
            this.Symbol = 'B';
            this.Height = 100;
            this.Width = 90;
            this.Ascent = 7;
            this.Descent = 0;
        }

        public override void Display(int pointSize)
        {
            Console.WriteLine("{0} (point size {1})", this.Symbol, pointSize);
        }
    }
}
