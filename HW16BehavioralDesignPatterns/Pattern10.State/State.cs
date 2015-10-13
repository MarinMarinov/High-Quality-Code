namespace Pattern10.State
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    public abstract class State
    {
        protected State(Player player)
        {
            this.Player = player;
        }

        protected Player Player { get; private set; }

        protected int Speed { get; set; }

        protected int LowerStrenghtLimit { get; set; }

        protected int UpperStrenghtLimit { get; set; }

        public abstract void EatSpinach(int amount); 

        public abstract void DrinkAlcohol(int amount);

        public abstract void Run();      
    }
}