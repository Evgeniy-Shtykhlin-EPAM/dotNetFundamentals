using System;
using StandartLibrary;
namespace ConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter username for task 1");
            var username = Console.ReadLine();
            FooTask1(username);
            Console.WriteLine("Enter username for task 2");
            username = Console.ReadLine();
            FooTask2(username);
            Console.ReadKey();
        }
        static void FooTask1(string username)
        {
            Console.WriteLine($"Hello, {username}");
        }
        static void FooTask2(string username)
        {
            var message = LibraryClass.AddDateTimeNowToPhrase(username);
            Console.WriteLine(message);
        }
    }
}
