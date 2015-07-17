namespace _01.CodeFormatting
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int my_byDate = this.date.CompareTo(other.date);
            int my_byTitle = this.title.CompareTo(other.title);
            int my_byLocation = this.location.CompareTo(other.location);

            if (my_byDate == 0)
            {
                if (my_byTitle == 0)
                {
                    return my_byLocation;
                }
                else
                {
                    return my_byTitle;
                }
            }
            else
            {
                return my_byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (this.location != null && this.location != string.Empty)
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}
