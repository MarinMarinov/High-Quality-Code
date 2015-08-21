namespace Task1Log4NetExample
{
    using System;
    using log4net;
    using log4net.Config;

    public class Logger
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Logger));

        public static void Main(string[] args)
        {
            BasicConfigurator.Configure(); //// will log on the Console
            ////XmlConfigurator.Configure(); // will log on the log.txt file in bin/debug folder

            Log.Info("Start logging!");

            try
            {
                Log.Warn("Trying to parse double type number");
                Console.WriteLine("Enter some number if you want to parse to double, or enter string to activate Exception");
                double number = double.Parse(Console.ReadLine());
            }
            catch (FormatException exception)
            {
                Log.Error("FormatException when parsing input to double");
                Console.WriteLine(exception.GetType() + "was thrown when trying to parse input to double");
            }
            finally
            {
                Log.Info("This is logger message from the finally block of the try-catch-finally block");
                Console.WriteLine("I am clossing the program");
            }

            Log.Info("End logging");
        }
    }
}
