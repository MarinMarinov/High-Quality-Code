using System;
using System.Collections.Generic;

namespace Pattern3.FlyWeight
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public int NumberOfCharacters
        {
            get
            {
                return this.characters.Count;
            }
        }

        public Character GetCharacter(char key)
        {
            Character character = null;

            //Using Lazy initialization
            if (this.characters.ContainsKey(key))
            {
                character = this.characters[key];
            }
            else
            {
                switch (key)
                {
                    case 'A':
                        character = new CharacterA(); break;
                    case 'B':
                        character = new CharacterB(); break;
                    case 'C':
                        character = new CharacterC(); break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                this.characters.Add(key, character);
            }

            return character;
        }
    }
}
