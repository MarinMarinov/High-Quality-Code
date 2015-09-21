using System;
using System.Collections.Generic;

namespace Pattern1.Singleton
{
    /// <summary>
    /// This is thread-safe implemetation of the Singleton Pattern
    /// </summary>
    public class Logger
    {
        private static volatile Logger loggerInstance; //The volatile modifier is usually used for a field that is 
        // accessed by multiple threads without using the lock statement to serialize access

        private readonly IList<Event> events = new List<Event>();
        private static object locker = new object();

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (loggerInstance == null)
                {
                    lock (locker)
                    {
                        if (loggerInstance == null)
                        {
                            loggerInstance = new Logger();
                        }
                    }
                }

                return loggerInstance;
            }
        }

        public void SaveEvent(object message)
        {
            lock(locker){

                this.events.Add(new Event(message.ToString()));
            }
        }

        public void PrintEvents()
        {
            foreach (Event ev in events)
            {
                Console.WriteLine("The event mesage is: '{0}' and has been added on {1}", ev.Message, ev.Date);
            }
        }
    }
}
