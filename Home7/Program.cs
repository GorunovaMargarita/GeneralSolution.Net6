using System;


namespace Home7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataGenerator generate = new DataGenerator();

            Employee cook = generate.Cook();
            Employee cleaner = generate.Cleaner();
            Employee manager = generate.Manager();

            Console.WriteLine(cook.ToString());
            Console.WriteLine(cleaner.ToString());
            Console.WriteLine(manager.ToString());

            cook.DoWork();
            cleaner.DoWork();
            manager.DoWork();
        }
    }
}
