namespace Task02.PersonGenerator
{
    public class PersonGenerator
    {
        public static Person MakePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "Toughguy";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Beauty";
                newPerson.Gender = Gender.Female;
            }

            return newPerson;
        }
    }
}
