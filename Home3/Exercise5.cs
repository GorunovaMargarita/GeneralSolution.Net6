
namespace Home3
{
    internal class Exercise5
    {
        /*5. Создайте массив строк. Заполните его произвольными именами людей.  
             Отсортируйте массив.  
             Результат выведите на консоль.    */
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise5) + "\n"}");

            string[] array = { "Паша", "Митя", "Вася", "Юля", "Оля", "Андрей", "Егор", "Артур" };

            Console.WriteLine("Current array: ");

            foreach (string str in array)
            {
                Console.Write(str + "\t");
            }

            array = Common.SortStringArray(array);

            Console.WriteLine("\nSorted array: ");

            foreach (string str in array)
            {
                Console.Write(str + "\t");
            }
        }
    }
}
