
namespace Home3
{
    internal class Exercise3
    {
        /*3. Создайте 2 массива из 5 чисел.  
            Выведите массивы на консоль в двух отдельных строках.  
            Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).    */
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise3) + "\n"}");

            int[] firstArray = Common.GenerateArrayIntRandomNumbers(5);
            int[] secondArray = Common.GenerateArrayIntRandomNumbers(5);
            double averageDiff;

            Console.WriteLine("First array: ");

            foreach (int num in firstArray)
            {
                Console.Write(num + "\t");
            }

            Console.WriteLine("\nSecond array: ");

            foreach (int num in secondArray)
            {
                Console.Write(num + "\t");
            }

            Console.WriteLine($"\nAverage first array: {Common.ArrayAverage(firstArray)}");

            Console.WriteLine($"\nAverage second array: {Common.ArrayAverage(secondArray)}");

            averageDiff = Common.ArrayAverage(firstArray) - Common.ArrayAverage(secondArray);

            switch (averageDiff)
            {
                case 0:
                    Console.WriteLine("\nAverage equals.");
                    break;
                case > 0:
                    Console.WriteLine($"\nAverage of first array more (diff {averageDiff})");
                    break;
                case < 0:
                    Console.WriteLine($"\nAverage of second array more (diff {Math.Abs(Math.Round(averageDiff, 2))})");
                    break;
            }
        }
    }
}
