
namespace Home3
{
    internal class Exercise8
    {
        /*8 Создайте двумерный массив. Выведите на консоль диагонали массива.*/
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise8) + "\n"}");

            Random random = new Random();
            int[,] matrixNew = new int[5, 5];

            Console.WriteLine("Current matrix: ");
            for (int i = 0; i < matrixNew.GetLength(1); i++)
            {
                for (int j = 0; j < matrixNew.GetLength(0); j++)
                {
                    matrixNew[i, j] = random.Next(11, 39);
                    Console.Write(matrixNew[i, j] + " ");
                }
                Console.WriteLine();
            };

            Console.WriteLine("Diagonal of matrix: ");

            for (int i = 0; i < matrixNew.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNew.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrixNew[i, j] + " ");
                    }
                }
            };

            Console.WriteLine("\nBack diagonal of matrix: ");

            for (int i = matrixNew.GetLength(1) - 1; i >= 0; i--)
            {
                Console.Write(matrixNew[i, matrixNew.GetLength(1) - 1 - i] + " ");
            };
        }
    }
}
