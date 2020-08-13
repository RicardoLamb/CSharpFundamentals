using System;

namespace Delegates
{
    delegate void StringProcessor(string input);

    class Person
    {
        string name;
        public Person(string name) { this.name = name; }

        public void Say(string message)
        {
            Console.WriteLine("{0} says: {1}", name, message);
        }
    }
}