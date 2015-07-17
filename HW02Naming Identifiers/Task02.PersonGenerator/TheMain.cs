namespace Task02.PersonGenerator
{
    using System;

    public class TheMain
    {
        static void Main()
        {
            Person malePerson = PersonGenerator.MakePerson(18);
            Console.WriteLine(malePerson.Name);
            Console.WriteLine(malePerson.Age);
            Console.WriteLine(malePerson.Gender);
        }
    }
}
