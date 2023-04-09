
namespace Home3
{
    internal class Exercise1
    {
        /*1. Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.  
            Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.  
            В результате должен быть новый массив без указанного числа.  */
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise1) + "\n"}");

            int[] array = Common.GenerateArrayIntRandomNumbers(10);

            Console.WriteLine("Current array: ");
            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }

            Console.WriteLine("\nPlease, enter number.");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (Common.IsNumberInArray(array, number))
                {
                    array = Common.RemoveNumberFromArray(array, number);
                    Console.WriteLine("New array: ");
                    foreach (int num in array)
                    {
                        Console.Write(num + "\t");
                    }
                }
            }
        }
    }
}
