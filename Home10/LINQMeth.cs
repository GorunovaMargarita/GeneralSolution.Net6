using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home10
{
    public class LINQMeth
    {
        public static void ShowFullName(User user)
        {
            List<string> names = new List<string>
                {
                    user.FirstName,
                    user.MiddleName,
                    user.LastName
                };
            Console.WriteLine(string.Join(' ', names.Where(name => !String.IsNullOrWhiteSpace(name))));
        }
        public static List<User> SortUsersByLastName(List<User> users)
        {
            return users.OrderByDescending(user => user.LastName).ToList();
        }
        public static void ReverseDictionaryToList(Dictionary<int, string> dictionary)
        {
            List<string> words = new List<string>();
            Console.WriteLine("\nInitial Dictionary: \n");
            foreach (var pair in dictionary)
            {
                words.Add(pair.Key.ToString());
                words.Add(pair.Value);
                Console.WriteLine($"({pair.Key}, {pair.Value})");
            }
            List<string> reverseList = new List<string>();
            for (int i = 0; i < words.Count - 1; i++)
            {
                reverseList.AddRange(words.Take(2).Reverse<string>());
                words.RemoveRange(0, 2);
            }
            Console.WriteLine("List of reversed key-values: \n");
            foreach (string word in reverseList)
            {
                Console.WriteLine(word + " ");
            }
        }

        public static void ShowMinWordLength(List<string> words)
        {
            Console.WriteLine("The length of the most short word: " + words.Min(word => word.Length));
        }

        public static void ShowValuesWith(int startIndex, string part)
        {
            Console.WriteLine("Please, enter word with white spaces.\n");
            List<string> listFromConsole = Console.ReadLine().Split(' ').ToList();
            var listWithThree = listFromConsole.Skip(startIndex - 1).Where(word => word.Contains(part));
            Console.WriteLine($"\nValues from 5th element with '{part}': ");
            foreach (var word in listWithThree)
            {
                Console.WriteLine(word);
            }
        }

        public static void ShowUnicWordsCount(List<string> words)
        {
            Console.WriteLine("The unique word count: " + words.Distinct().ToList().Count());
        }

        public static void ShowLastWordWithLength(List<string> words, int minLength, int maxLength)
        {
            Console.WriteLine($"The last word with length between {minLength} and {maxLength}(or null): " + words.LastOrDefault(word => word.Length > minLength && word.Length < maxLength, "null"));
        }

        public static void ShowLastWordWithPart(List<string> words, string part)
        {
            Console.WriteLine($"The last word with '{part}': " + words.Last(word => word.Contains(part)));
        }

        public static void ShowFirstOneLetterWord(List<string> words)
        {
            Console.WriteLine("The first word with 1 letter: " + words.First(word => word.Length == 1));
        }
    }
}
