using System;

namespace Pattern7.FluentInterface
{
    class Program
    {
        static void Main()
        {
            Person alex = new Person();

            alex.FirstName("Alex")
                .LastName("Marinov")
                .Age(2)
                .Gender("Male")
                .City("Sofia")
                .PrintData();

            Console.WriteLine("---------------------------------");

            Person john = new Person();

            john.LastName("Smith")
                .FirstName("John")
                .City("London")
                .Gender("Male")
                .Age(32)
                .PrintData();
        }
    }
}
