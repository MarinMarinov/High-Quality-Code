using System;

namespace Pattern3.FlyWeight
{
    class CharacterC : Character
    {
        public CharacterC()
        {
            this.Symbol = 'C';
            this.Height = 100;
            this.Width = 60;
            this.Ascent = 0;
            this.Descent = 0;
        }

        public override void Display(int pointSize)
        {
            Console.WriteLine("{0} (point size {1})", this.Symbol, pointSize);
        }
    }
}
