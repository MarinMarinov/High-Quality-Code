using System;

namespace Pattern10.State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Low Strenght indicates unable to run state;
    /// </remarks>
    /// </summary>
    public class LowStrengthState : State
    {
        public LowStrengthState(Player player)
            : base(player)
        {
            this.Speed = 0;
            this.LowerStrenghtLimit = 0;
            this.UpperStrenghtLimit = 20;
        }

        public override void EatSpinach(int amount)
        {
            this.Player.Strength += amount;

            if (this.Player.Strength > this.UpperStrenghtLimit)
            {
                this.Player.State = new MediumStrengthState(this.Player);
                Console.WriteLine("{0} have eaten a lot of spinach and accelerated his Speed",
                    this.Player.Name);
            }
        }

        public override void DrinkAlcohol(int amount)
        {
            this.Player.Strength -= amount;

            if (this.Player.Strength < LowerStrenghtLimit)
            {
                Console.WriteLine("{0} are totaly drunk, and have no strength left!", this.Player.Name);
            }
        }

        public override void Run()
        {
            Console.WriteLine("{0} is drunk, and can't run at all!", this.Player.Name);
        }
    }
}
