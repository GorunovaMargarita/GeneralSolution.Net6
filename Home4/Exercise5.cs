
namespace Home4
{
    /*5. Введите с консоли строку, которая будет содержать буквы и цифры. Удалите из исходной строки все цифры и выведите их на экран.
    (Использовать метод Char.IsDigit(), его не разбирали на уроке, посмотрите, пожалуйста, документацию этого метода самостоятельно)*/
    public class Exercise5
    {
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise5) + "\n"}");

            Console.WriteLine("Please, enter string.");

            string initialString = Console.ReadLine();

            if (!String.IsNullOrEmpty(initialString))
            {
                Console.WriteLine($"Result string: \n {Common.RemoveDigitsFromString(initialString)}");
            }
            else
            {
                Console.WriteLine("String is null or empty");
            }
        }
    }
}
