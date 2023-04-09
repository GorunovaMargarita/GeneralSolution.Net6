
namespace Home3
{
    internal class Exercise2
    {
        /*2. Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.  
            Для генерации случайного числа используйте метод Random() .  Пусть будет возможность создавать массив произвольного размера.  Пусть размер массива вводится с консоли.  */
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise2) + "\n"}");

            Console.WriteLine("Please, enter count of element in array.");

            int.TryParse(Console.ReadLine(), out int arrayDim);

            int[] array = Common.GenerateArrayIntRandomNumbers(arrayDim);

            Console.WriteLine("Current array: ");

            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }

            Console.WriteLine($"\nMax value in array: {Common.GetMaxNumberInArray(array)}");

            Console.WriteLine($"\nMin value in array: {Common.GetMinNumberInArray(array)}");

            Console.WriteLine($"\nAverage of array: {Common.ArrayAverage(array)}");
        }
    }
}
