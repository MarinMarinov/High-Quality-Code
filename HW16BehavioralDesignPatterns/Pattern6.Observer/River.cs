using System;
using System.Collections.Generic;

namespace Pattern6.Observer
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class River
    {
        private const int Step = 2;
        private readonly List<IObserver> observers = new List<IObserver>();
        private readonly string name;
        private int waterLevel;

        protected River(string name, int initialWaterLevel)
        {
            this.name = name;
            this.waterLevel = initialWaterLevel;
        }

        public int WaterLevel
        {
            get { return this.waterLevel; }
            set
            {
                if (Math.Abs(this.waterLevel - value) > Step)
                {
                    this.waterLevel = value;
                    this.Notify();
                }
                else
                {
                    Console.WriteLine("Sans changement!");
                }
            }
        }

        public string Name { get { return this.name;  } }

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update(this);
            }
        }
    }
}
