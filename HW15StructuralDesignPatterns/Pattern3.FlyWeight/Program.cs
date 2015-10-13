using System;

namespace Pattern3.FlyWeight
{
    class Program
    {
        static void Main()
        {
            string text = "ABCAABB";

            CharacterFactory characterFactory = new CharacterFactory();

            //  extrinsic state
            int pointSize = 10;

            // For each character use a flyweight object
            foreach (char symbol in text)
            {
                pointSize++;
                Character character = characterFactory.GetCharacter(symbol);
                character.Display(pointSize);
            }

            Console.WriteLine("Total nuumber of characters in the object: {0}", characterFactory.NumberOfCharacters);
        }
    }
}
