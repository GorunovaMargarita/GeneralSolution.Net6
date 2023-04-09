

namespace Home4
{
    /*6. Задайте 2 предложения из консоли. Для каждого слова первого предложения определите количество его вхождений во второе предложение.*/
    public class Exercise6
    {
        public static void Run()
        {
            Console.WriteLine($"{"\n" + nameof(Exercise6) + "\n"}");

            Console.WriteLine("Please, enter first string.");

            string firstString = Console.ReadLine();

            Console.WriteLine("Please, enter second string.");

            string secondString = Console.ReadLine();

            if(!String.IsNullOrEmpty(firstString) || !String.IsNullOrEmpty(secondString))
            {
                string[] wordsFromFirstString = firstString.Split(" ");
                string[] wordsFromSecondString = secondString.Split(" ");

                foreach (string word in wordsFromFirstString)
                {
                    int count = 0;
                    foreach (string word2 in wordsFromSecondString)
                    {
                        if (word2.Equals(word, StringComparison.CurrentCultureIgnoreCase))
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"\"{word}\" enter to second string {count} times");
                }
            }
            else
            {
                Console.WriteLine("String is null or empty");
            }
        }
    }
}
