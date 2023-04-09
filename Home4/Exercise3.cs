
using System.Text;

namespace Home4
{
    /*3. Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart, а также всё, что после них во вторую secondPart. 
        Результат вывести в консоль. */
    public class Exercise3
    {
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise3) + "\n"}");

            string initialString = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string controlWord = "abc";
            string firstPart = String.Empty;
            string secondPart = String.Empty;

            var array = initialString.Split(controlWord);
            firstPart = array[0];
            secondPart = array[1];

            Console.WriteLine($"First part: \n {firstPart}");
            Console.WriteLine($"Second part: \n {secondPart}");
        }
    }
}
