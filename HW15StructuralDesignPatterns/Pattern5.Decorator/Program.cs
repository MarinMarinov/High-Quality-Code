using System;

namespace Pattern5.Decorator
{
    class Program
    {
        static void Main()
        {
            Book book = new Book("Ernest Hemingway", "For Whom the Bell Tolls", 100, 480);

            Song song = new Song("Metallica", "For Whom the Bell Tolls", 120, 5.12);

            book.Display();
            song.Display();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Make the book and song borrowable and three books borrowed");
            Borrowable borrowableBook = new Borrowable(book);
            Borrowable borrowableSong = new Borrowable(song);

            borrowableBook.BorrowItem("Marin Marinov");
            borrowableBook.BorrowItem("Ivan Ivanov");
            borrowableBook.BorrowItem("Dimitar Dimitrov");
            borrowableBook.Display();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Two books returned");
            borrowableBook.ReturnItem("Marin Marinov");
            borrowableBook.ReturnItem("Ivan Ivanov");
            borrowableBook.Display();         
        }
    }
}
