using System;

namespace ValuesVsReferences
{
    public struct Dog
    {
        public string Name;
        public string Breed;

        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }

        public void Speak()
        {
            Console.WriteLine("My name is {0} and I’m a {1}.", Name, Breed);
        }
    }
}
