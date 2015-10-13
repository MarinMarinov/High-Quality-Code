using System;

namespace Pattern5.Decorator
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    internal class Song : AbstractItem
    {
        private readonly string author;
        private readonly string title;
        private readonly double playTime;

        public Song(string author, string title, int copies, double playTime)
        {
            this.author = author;
            this.title = title;
            this.CopiesCount = copies;
            this.playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("Song: {0}", this.title);
            Console.WriteLine("Author: {0}", this.author);
            Console.WriteLine("Playtime: {0}", this.playTime);
            Console.WriteLine("Number of copies: {0}", this.CopiesCount);
        }
    }
}
