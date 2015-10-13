using System;

namespace Pattern5.Decorator
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    internal class Book : AbstractItem
    {
        private readonly string author;
        private readonly string title;
        private readonly int pages;

        public Book(string author, string title, int copies, int pages)
        {
            this.author = author;
            this.title = title;
            this.CopiesCount = copies;
            this.pages = pages;
        }

        public override void Display()
        {
            Console.WriteLine("Book: {0}", this.title);
            Console.WriteLine("Author: {0}", this.author);
            Console.WriteLine("Pages: {0}", this.pages);
            Console.WriteLine("Number of copies: {0}", this.CopiesCount);
        }
    }
}
