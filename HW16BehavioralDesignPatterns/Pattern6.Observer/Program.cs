using System;

namespace Pattern6.Observer
{
    class Program
    {
        static void Main()
        {
            IObserver observerRuse = new RuseObserver();
            IObserver observerVidin = new VidinObserver();

            River danube = new DanubeRiver("Danube", 573);

            Console.WriteLine("{0} river initial water level: {1}", danube.Name, danube.WaterLevel);

            danube.Attach(observerRuse);
            danube.Attach(observerVidin);
            
            danube.WaterLevel = 573;

            danube.WaterLevel = 614;

            Console.WriteLine("Detaching Vidin Observer Station");
            danube.Detach(observerVidin);

            danube.WaterLevel = 475;
            danube.WaterLevel = 475;
        }
    }
}
