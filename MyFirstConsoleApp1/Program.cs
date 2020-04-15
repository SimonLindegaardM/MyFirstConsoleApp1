using System;

namespace MyFirstConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Person Person1 = new Person("Simon", 23);
            Person Person2 = new Person("Bob", 69);
            Console.WriteLine($"Den første person hedder {Person1.name}, og er {Person1.age} år gammel");
            Console.WriteLine($"Den anden person hedder {Person2.name}, og er {Person2.age} år gammel");
        }
    }
}
