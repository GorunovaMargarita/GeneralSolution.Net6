
namespace Home3
{
    internal class Exercise0
    {
        /*0.    Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.  Пусть число для поиска задается с консоли.*/
        public static void Run()
        {
            Console.WriteLine($"{nameof(Exercise0)}");

            int[] array = Common.GenerateArrayIntRandomNumbers(10);

            Console.WriteLine("\nCurrent array: ");
            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }

            Console.WriteLine("\nPlease, enter number.");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Common.IsNumberInArray(array, number); 
            }
            else
            {
                Console.WriteLine("It is not a number.");
            }
        }

    }
}
