
namespace Home3
{
    internal class Exercise6
    {
        /*6.Реализуйте алгоритм сортировки массива пузырьком. */
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise6) + "\n"}");

            int[] array = Common.GenerateArrayIntRandomNumbers(10);

            Console.WriteLine("Current array: ");

            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }

            array = Common.SortArrayByBubbleMethod(array);

            Console.WriteLine("\nSorted array: ");

            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }
        }
    }
}
