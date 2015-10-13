using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern10.State
{
    public class MediumStrengthState : State
    {
        public MediumStrengthState(Player player)
            : base(player)
        {
            this.Speed = 5;
            this.LowerStrenghtLimit = 20;
            this.UpperStrenghtLimit = 60;
        }

        public override void EatSpinach(int amount)
        {
            this.Player.Strength += amount;

            if (this.Player.Strength > this.UpperStrenghtLimit)
            {
                this.Player.State = new HighStrengthState(this.Player);
                Console.WriteLine("{0} have eaten a lot of spinach and accelerated his Speed",
                    this.Player.Name);
            }
        }

        public override void DrinkAlcohol(int amount)
        {
            this.Player.Strength -= amount;

            if (this.Player.Strength < LowerStrenghtLimit)
            {
                this.Player.State = new LowStrengthState(this.Player);
                Console.WriteLine("{0} have drunk too much alcohol, and now is down to Low Strength State!", this.Player.Name);
            }
        }

        public override void Run()
        {
            Console.WriteLine("Now {0} run with Speed of: {1}", this.Player.Name, this.Speed);
        }
    }
}
