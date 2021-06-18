using System;

namespace Exercise_1
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            Person person = new Person();
            person.Name = "Amar";
            person.Age = 40;
            Console.WriteLine("Simple Preperties Demo");
            Console.WriteLine("Person details - {0}", person.ToString());
            person.Age += 1;
            Console.WriteLine("Person details <After incrementing age> - {0}", person.ToString());
            Console.ReadLine();
        }
    }
}