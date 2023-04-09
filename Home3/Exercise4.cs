using System;
using System.Collections.Generic;
using System.Linq;

namespace Home3
{
    internal class Exercise4
    {
        /*4. Создайте массив и заполните массив.  
            Выведите массив на экран в строку.  
            Замените каждый элемент с нечётным индексом на ноль.  
            Снова выведете массив на экран на отдельной строке. */
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise4) + "\n"}");

            Console.WriteLine("Please, enter count of element in array.");

            int.TryParse(Console.ReadLine(), out int arrayDim);

            int[] array = Common.GenerateArrayIntRandomNumbers(arrayDim);

            Console.WriteLine("Current array: ");

            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }

            array = Common.ChangeArrayNumsWithOddIndexToZero(array);

            Console.WriteLine("\nWe change values with odd index to zero and get new array: ");

            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }
        }
    }
}
