

namespace Home4
{
    /*1. Задать строку содержащую внутри цифры и несколько повторений слова test, Заменить в строке все вхождения 'test' на 'testing'.  */
    public class Exercise1
    {
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise1) + "\n"}");

            string initialString = "We love test, we need test. Test is amazing! Tes is not test! I'am a test engineer. I test for 10 years. I'm test wery well.";
            string replacebleValue = "test";
            string newValue = "testing";

            Console.WriteLine($"Initial string: \n {initialString}");

            Console.WriteLine($"\nWe replace {replacebleValue} to {newValue} and get string: \n {initialString.Replace(replacebleValue, newValue)}");

            Console.WriteLine($"\nIf we want to ignore case, we will get string: \n {initialString.Replace(replacebleValue, newValue, StringComparison.OrdinalIgnoreCase)}");
        }
    }
}
