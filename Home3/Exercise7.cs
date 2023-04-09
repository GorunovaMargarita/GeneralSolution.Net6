
namespace Home3
{
    internal class Exercise7
    {
        /*7. Создайте двумерный массив целых чисел. Выведите на консоль сумму всех элементов массива.*/
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise7) + "\n"}");

            Random random = new Random();
            int[,] matrixNew = new int[3, 3];

            Console.WriteLine("Current array: ");
            for (int i = 0; i < matrixNew.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNew.GetLength(1); j++)
                {
                    matrixNew[i, j] = random.Next(1, 5);
                    Console.Write(matrixNew[i, j] + " ");
                }
                Console.WriteLine();
            };

            Console.WriteLine($"Sum elements of array: {Common.SumElementsOfTwoDimMass(matrixNew)}");
        }
    }
}
