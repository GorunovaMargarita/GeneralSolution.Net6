
namespace Home3
{
    public class Common
    {
        public static void GetArrayOfEvenNumbersFromCurrentArray(int[] array)
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
        public static int GetDimFromConsole()
        {
            Console.WriteLine("Please, enter count of element in array (from 5 to 10).");

            if (!int.TryParse(Console.ReadLine(), out int arrayDim) || arrayDim < 5 || arrayDim > 10)
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

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
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

