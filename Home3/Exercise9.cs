

namespace Home3
{
    internal class Exercise9
    {
        /*9. Создайте массив из n случайных целых чисел и выведите его на экран.  
            Размер массива пусть задается с консоли и размер массива может быть больше 5 и меньше или равно 10.  
            Если n не удовлетворяет условию - выведите сообщение об этом.  Если пользователь ввёл не подходящее число, то программа должна просить пользователя повторить ввод.  
            Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.*/
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise9) + "\n"}");

            int arrayDim = Common.GetDimFromConsole();

            int[] array = Common.GenerateArrayIntRandomNumbers(arrayDim);

            Console.WriteLine("Current array: ");

            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }

            Common.GetArrayOfEvenNumbersFromCurrentArray(array);
        }
    }
}
