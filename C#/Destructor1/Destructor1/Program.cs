using System;

namespace Destructor1
{
    class Person
    {
        public string Name;
        public int Age;

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string getName()
        {
            return this.Name;
        }

        public int getAge()
        {
            return this.Age;
        }

        ~Person()
        {
            Console.WriteLine("Destructor has been invoked.");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Person Bipin = new Person("Bipin", 21);
                Console.WriteLine("Name: " + Bipin.getName());
                Console.WriteLine("Age: " + Bipin.getAge());

                Console.ReadKey();
            }
        }
    }
}
