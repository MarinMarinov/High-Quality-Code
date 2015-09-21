using System;

namespace Pattern7.FluentInterface
{
    public class Person
    {
        private readonly PersonData personData = new PersonData();

        public Person FirstName(string firstName) // Not the best naming for methods
        {
            this.personData.FirstName = firstName;
            return this;
        }

        public Person LastName(string lastName)
        {
            this.personData.LastName = lastName;
            return this;
        }

        public Person Age(int age)
        {
            this.personData.Age = age;
            return this;
        }

        public Person Gender(string gender)
        {
            this.personData.Gender = gender;
            return this;
        }

        public Person City(string city)
        {
            this.personData.City = city;
            return this;
        }

        public void PrintData()
        {
            Console.WriteLine("first name: {0} \nlast name: {1} \nage: {2}\ngender: {3} \naddress: {4}",
                this.personData.FirstName, this.personData.LastName, this.personData.Age, this.personData.Gender, this.personData.City);
        }
    }
}
