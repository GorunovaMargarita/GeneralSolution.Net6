using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home10
{
    public class Task4
    {
        public static void Run()
        {
            string someText = "Ужасно не хотелось рассказывать ему – что да как. Все равно он бы ничего не понял. Не по его это части. А ушел я из Элктон-хилла главным образом потому, что там была одна сплошная липа. Все делалось напоказ – не продохнешь. Например, их директор, мистер Хаас. Такого подлого притворщика я в жизни не встречал. В десять раз хуже старика Термера. По воскресеньям, например, этот чертов Хаас ходил и жал ручки всем родителям, которые приезжали. И до того мил, до того вежлив – просто картинка. Но не со всеми он одинаково здоровался – у некоторых ребят родители были попроще, победнее. Вы бы посмотрели, как он, например, здоровался с родителями моего соседа по комнате. Понимаете, если у кого мать толстая или смешно одета, а отец ходит в костюме с ужасно высокими плечами и башмаки на нем старомодные, черные с белым, тут этот самый Хаас только протягивал им два пальца и притворно улыбался, а потом как начнет разговаривать с другими родителями – полчаса разливается! Не выношу я этого. Злость берет. Так злюсь, что с ума можно спятить. Ненавижу я этот проклятый Элктон-хилл.";
            List<string> wordsFromText = someText.ToLower().Split(new[] { ',', '.', ' ', ';', ':', '?', '!', '–' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            /*- Метод возвращает первое слово из последовательности слов, содержащее только одну букву.*/
            LINQMeth.ShowFirstOneLetterWord(wordsFromText);

            /*- метод, возвращающий последнее слово, содержащее в себе подстроку «ее». Реализовать, используя только 1 метод LINQ.*/
            LINQMeth.ShowLastWordWithPart(wordsFromText, "ее");

            /*- Реализовать метод для возврата последнего слова, соответствующего условию: длина слова не меньше min и не больше max. Если нет слов, соответствующих условию, метод возвращает null.*/
            LINQMeth.ShowLastWordWithLength(wordsFromText, 8, 10);

            /*- Напишите метод, который возвращает количество уникальных значений в массиве.*/
            LINQMeth.ShowUnicWordsCount(wordsFromText);

            ///*- Напишите метод, который принимает список и извлекает значения с 5  элемента (включительно)  те значение которые содержат 3*/
            LINQMeth.ShowValuesWith(5, "3");

            /*- Метод возвращает длину самого короткого слова*/
            LINQMeth.ShowMinWordLength(wordsFromText);

            /* Напишите метод, который преобразует словарь в список и меняет местами каждый ключ и значение */
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)
            {
                dictionary.Add(i, "word" + i);
            }

            LINQMeth.ReverseDictionaryToList(dictionary);

            /*-Напишите метод, который возвращает "<FirstName> <MiddleName> <LastName>", если отчество присутствует Или "<FirstName> <LastName>", если отчество отсутствует.*/
            List<User> users = new List<User>
            {
                new User("Ivan", null, "Ivanov"),
                new User("Petr", "Petrovich", "Generalov"),
                new User("Anton", "Antonovich","Uvarov"),
                new User("Maksim", "", "Yazov"),
                new User("Klement", "Aleksandrovich", "Pushnoy")
            };

            Console.WriteLine("\nUnsorted users list: \n");
            foreach (var user in users)
            {
                LINQMeth.ShowFullName(user);
            }

            /*-Напишите метод, который возвращает предоставленный список пользователей, упорядоченный по LastName в порядке убывания.*/
            Console.WriteLine("\nSorted list of users (decreasing LastName): \n");
            var sortedUsers = LINQMeth.SortUsersByLastName(users);
            foreach (var user in sortedUsers)
            {
                LINQMeth.ShowFullName(user);
            }

        }

    }
}
