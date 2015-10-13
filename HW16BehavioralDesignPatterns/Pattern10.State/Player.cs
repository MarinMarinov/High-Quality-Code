using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern10.State
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Player
    {
        public Player(string name)
        {
            this.Name = name;
            this.Strength = 20;
            this.State = new MediumStrengthState(this);
        }
            
        public string Name { get; set; }

        public State State { get; set; }

        public int Strength { get; set; }

        public void EatSpinach(int amount)
        {
            this.State.EatSpinach(amount);
            Console.WriteLine("\nSpinach ate: {0}", amount);
            Console.WriteLine(" Strength = {0}", this.Strength);
            Console.WriteLine(" Status  = {0}\n", this.State.GetType().Name);
            Console.WriteLine();
        }

        public void DrinkAlcohol(int amount)
        {
            this.State.DrinkAlcohol(amount);
            Console.WriteLine("\nAlcohol drank: {0}", amount);
            Console.WriteLine(" Strength = {0}", this.Strength);
            Console.WriteLine(" Status  = {0}\n", this.State.GetType().Name);
            Console.WriteLine();
        }

        public void Run()
        {
            this.State.Run();
        }

        public void Show()
        {
            Console.WriteLine("\nPlayer name: {0}", this.Name);
            Console.WriteLine(" Strength = {0}", this.Strength);
            Console.WriteLine(" Status  = {0}\n", this.State.GetType().Name);
        }
    }
}
