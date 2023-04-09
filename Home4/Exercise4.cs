
using System.Text;

namespace Home4
{
    /*4. Дана строка: Good day 
    Необходимо с помощью метода substring удалить слово "Good". После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
    Заменить последний "!" на "?" и вывести результат на консоль. */
    public class Exercise4
    {
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise4) + "\n"}");

            string initialString = "Good day";
            string removableWord = "Good";
            string newBeginning = "The best";
            string newEnding = "!!!!!!!!!";
            string resultString = String.Empty;

            Console.WriteLine($"Initisl string: \n {initialString}");

            resultString = initialString.Substring(initialString.IndexOf(removableWord) + removableWord.Length);

            resultString = resultString.Insert(0, newBeginning);

            resultString = resultString.Insert(resultString.Length, newEnding);

            resultString = resultString.Remove(resultString.Length - 1);

            resultString = resultString.Insert(resultString.Length, "?");

            Console.WriteLine($"Result string: \n {resultString}");
        }
    }
}
