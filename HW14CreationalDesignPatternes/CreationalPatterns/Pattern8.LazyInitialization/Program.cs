using System;

namespace Pattern8.LazyInitialization
{
    class Program
    {
        static void Main()
        {
            var db = new DataContext();
            var user = db.GetUserById(1337);
            Console.WriteLine(user.Roles.Count);
        }
    }
}
