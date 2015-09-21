using System.Threading.Tasks;

namespace Pattern1.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger loggerInstance = Logger.Instance;

            loggerInstance.SaveEvent("Now I am finishing to implement Singleton Pattern");
            loggerInstance.SaveEvent("Now I am testing the implementation");

            Parallel.For(0, 5, x => loggerInstance.SaveEvent(x));

            loggerInstance.SaveEvent("End of the tests");
            loggerInstance.PrintEvents();                     

        }
    }
}
