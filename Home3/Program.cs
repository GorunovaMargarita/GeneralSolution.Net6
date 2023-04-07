using System;
using System.Globalization;

namespace Home3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write a number of task.");

            if (int.TryParse(Console.ReadLine(), out int taskNum))
            {
                if (taskNum == 1)
                {
                    int[] array = GenerateArrayIntRandomNumbers(10);

                    Console.WriteLine("Current array: ");

                    foreach (int num in array)
                    {
                        Console.Write(num + "\t");
                    }

                    Console.WriteLine("\nPlease, enter number.");

                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        array = RemoveNumberFromArray(array, number);

                        Console.WriteLine("New array: ");
                        foreach (int num in array)
                        {
                            Console.Write(num + "\t");
                        }
                    }
                }
                if (taskNum == 2)
                {
                    Console.WriteLine("Please, enter count of element in array.");

                    int.TryParse(Console.ReadLine(), out int arrayDim);

                    int[] array = GenerateArrayIntRandomNumbers(arrayDim);

                    Console.WriteLine("Current array: ");

                    foreach (int num in array)
                    {
                        Console.Write(num + "\t");
                    }

                    Console.WriteLine($"\nMax value in array: {GetMaxNumberInArray(array)}");

                    Console.WriteLine($"\nMin value in array: {GetMinNumberInArray(array)}");
                }
                if (taskNum == 3)
                {
                    int[] firstArray = GenerateArrayIntRandomNumbers(2);
                    int[] secondArray = GenerateArrayIntRandomNumbers(5);
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

                    Console.WriteLine($"\nAverage first array: {ArrayAverage(firstArray)}");

                    Console.WriteLine($"\nAverage second array: {ArrayAverage(secondArray)}");

                    averageDiff = ArrayAverage(firstArray) - ArrayAverage(secondArray);

                    switch (averageDiff)
                    {
                        case 0: 
                            Console.WriteLine("\nAverage equals.");
                            break;
                        case > 0:
                            Console.WriteLine($"\nAverage of first array more (diff {averageDiff})");
                            break;
                        case < 0:
                            Console.WriteLine($"\nAverage of second array more (diff {Math.Abs(Math.Round(averageDiff,2))})");
                            break;
                    }
                }
                if (taskNum == 4)
                {
                    Console.WriteLine("Please, enter count of element in array.");

                    int.TryParse(Console.ReadLine(), out int arrayDim);

                    int[] array = GenerateArrayIntRandomNumbers(arrayDim);

                    Console.WriteLine("Current array: ");

                    foreach (int num in array)
                    {
                        Console.Write(num + "\t");
                    }

                    array = ChangeArrayNumsWithOddIndexToZero(array);

                    Console.WriteLine("\nWe change values with odd index to zero and get new array: ");

                    foreach (int num in array)
                    {
                        Console.Write(num + "\t");
                    }
                }
                if (taskNum == 5)
                {
                    string[] array = { "Паша", "Митя", "Вася", "Юля", "Оля", "Андрей", "Егор", "Артур"};

                    Console.WriteLine("Current array: ");

                    foreach (string str in array)
                    {
                        Console.Write(str + "\t");
                    }

                    array = SortStringArray(array);

                    Console.WriteLine("\nSorted array: ");

                    foreach (string str in array)
                    {
                        Console.Write(str + "\t");
                    }
                }
                if (taskNum == 6)
                {
                    int[] array = GenerateArrayIntRandomNumbers(10);

                    Console.WriteLine("Current array: ");

                    foreach (int num in array)
                    {
                        Console.Write(num + "\t");
                    }

                    array = SortArrayByBubbleMethod(array);

                    Console.WriteLine("\nSorted array: ");

                    foreach (int num in array)
                    {
                        Console.Write(num + "\t");
                    }
                }
                if (taskNum == 7)
                {
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

                    Console.WriteLine($"Sum elements of array: {SumElementsOfTwoDimMass(matrixNew)}");
                }
                if (taskNum == 8)
                {
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
                if (taskNum == 9)
                {
                    int arrayDim = GetDimFromConsole();

                    int[] array = GenerateArrayIntRandomNumbers(arrayDim);

                    Console.WriteLine("Current array: ");

                    foreach (int num in array)
                    {
                        Console.Write(num + "\t");
                    }

                    GetArrayOfEvenNumbersFromCurrentArray(array);
                }
            }
            else
            {
                Console.WriteLine("Incorrect task number.");
            }
        }
        private static void GetArrayOfEvenNumbersFromCurrentArray(int[] array)
        {
            int countOfEvenNums = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    countOfEvenNums++;
                }
            }
            if (countOfEvenNums > 0)
            {
                int[] arrayOfEvenNums = new int[countOfEvenNums];
                int index = 0;

                foreach (int num in array)
                {
                    if (num % 2 == 0)
                    {
                        arrayOfEvenNums[index] = num;
                        index++;
                    }
                }
                Console.WriteLine("\nArray of even numbers: ");

                foreach (int num in arrayOfEvenNums)
                {
                    Console.Write(num + "\t");
                }
            }
            else
            {
                Console.WriteLine("We have no even numbers in array.");
            }
        }

        private static int GetDimFromConsole()
        {
            Console.WriteLine("Please, enter count of element in array (from 5 to 10).");

            if(!int.TryParse(Console.ReadLine(), out int arrayDim) || arrayDim < 5 || arrayDim > 10)
            {
                Console.WriteLine("Incorrect number");
                GetDimFromConsole();
            }

            return arrayDim;
        }

        public static bool IsNumberInArray(int[] array, int number)
        {
            bool isNumberInArray = false;

            if (array.Contains(number))
            {
                isNumberInArray = true;
                Console.WriteLine("Number is in Array!");
            }
            else
            {
                Console.WriteLine("Number is not in Array.");
            }
            return isNumberInArray;
        }

        public static int[] RemoveNumberFromArray(int[] array, int number)
        {
            if (IsNumberInArray(array, number))
            {
                foreach (int num in array)
                {
                    if (num == number)
                    {
                        int index = Array.IndexOf(array, num);
                        for (int i = index; i < array.Length - 1; i++)
                        {
                            int nextVal = array[i + 1];
                            array[i] = nextVal;
                        }
                        Array.Resize(ref array, array.Length - 1);
                    }
                }
            }
            return array;
        }

        public static int GetMaxNumberInArray(int[] array)
        {
            int maxNumber = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
            }
            return maxNumber;
        }
        public static int GetMinNumberInArray(int[] array)
        {
            int minNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }
            return minNumber;
        }

        public static int[] GenerateArrayIntRandomNumbers(int lengts)
        {
            Random random = new Random();
            int[] array = new int[lengts];

            for (int i = 0; i < lengts; i++)
            {
                array[i] = random.Next(0, 100);
            }

            return array;
        }

        public static double ArrayAverage(int[] array)
        {
            double sumNumbers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sumNumbers += (double)array[i];
            }

            return sumNumbers / array.Length;
        }

        public static int[] ChangeArrayNumsWithOddIndexToZero(int[] array)
        {
            int[] changedArray = new int[array.Length];

            for (int i = 0; i < changedArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    changedArray[i] = array[i];
                }
                else
                {
                    changedArray[i] = 0;
                }
            }

            return changedArray;
        }

        public static string[] SortStringArray(string[] array)
        {
            Array.Sort(array);

            return array;
        }

        public static int[] SortArrayByBubbleMethod(int[] array)
        {
            int t;

            for (int i = 0; i < array.Length ; i++)
            {
                for(int j = i + 1 ; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            return array;
        }

        public static int SumElementsOfTwoDimMass(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }
    }
}
