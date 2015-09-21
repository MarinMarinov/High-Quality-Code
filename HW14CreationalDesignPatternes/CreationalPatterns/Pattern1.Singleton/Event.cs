using System;

namespace Pattern1.Singleton
{
    public class Event
    {
        public Event(string message)
        {
            this.Message = message;
            this.Date = DateTime.Now;
        }

        public string Message { get; private set; }

        public DateTime Date { get; private set; }
    }
}
