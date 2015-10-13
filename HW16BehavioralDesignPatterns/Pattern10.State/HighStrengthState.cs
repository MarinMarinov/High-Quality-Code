using System;

namespace Pattern10.State
{
    public class HighStrengthState : State
    {
        public HighStrengthState(Player player)
            : base(player)
        {
            this.Speed = 10;
            this.LowerStrenghtLimit = 60;
            this.UpperStrenghtLimit = 100;
        }

        public override void EatSpinach(int amount)
        {
            this.Player.Strength += amount;

            if (this.Player.Strength > this.UpperStrenghtLimit)
            {
                Console.WriteLine("{0} have eaten a lot of spinach, but have reached the limit of his Speed: {1}",this.Player.Name, this.Speed);
            }
        }

        public override void DrinkAlcohol(int amount)
        {
            this.Player.Strength -= amount;

            if (this.Player.Strength < LowerStrenghtLimit)
            {
                this.Player.State = new MediumStrengthState(this.Player);
                Console.WriteLine("{0} have drunk too much alcohol, and now is down to Medium Strength State!", this.Player.Name);
            }
        }

        public override void Run()
        {
            Console.WriteLine("Now {0} run with Speed of: {1}! Run Forest, Run!",this.Player.Name, this.Speed);
        }
    }
}
