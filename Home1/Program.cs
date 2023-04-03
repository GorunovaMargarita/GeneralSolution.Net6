using System;


namespace Home1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your username.");
            string username = Console.ReadLine();
            Console.WriteLine($"Hello, {username}!");
            Console.WriteLine("Please, enter any for close.");
            Console.ReadLine();
        }
    }
}
