
using System.Text;

namespace Home4
{
    /*2. Создайте переменные, которые будут хранить следующие слова: (Welcome, to, the, TMS, lessons)выполните конкатенацию слов и выведите на экран следующую фразу: Welcome to the TMS lessons. 
        Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова*/
    public class Exercise2
    {
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise2) + "\n"}");

            string first = "Welcome";
            string second = "to";
            string third = "the";
            string fourth = "TMS";
            string fifth = "lessons";
            string[] wordArray = new string[] { first, second, third, fourth, fifth };
            string resultString = String.Empty;

            for ( int i = 0; i < wordArray.Length; i++ ) 
            {
                wordArray[i] = Common.AddQuots(wordArray[i]);
            }

            resultString = String.Join(" ", wordArray);

            Console.WriteLine($"Result string: \n {resultString}");
        }
    }
}
