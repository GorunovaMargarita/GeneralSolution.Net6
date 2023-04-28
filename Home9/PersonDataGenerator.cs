using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9
{
    public class PersonDataGenerator
    {
        private static string[] someNames = new string[] { "Иван", "Олег", "Анна", "Денис", "Дарья", "Елена", "Максим", "Алексей", "Фёдор", "Мирон", "Наталья", "Николай", "Александр", "Марина" };
        public List<Person> GeneratePersonList(int personCount)
        {
            var personList = new List<Person>();
            for(int i = 0; i < personCount; i++)
            {
                personList.Add(new Person(someNames[new Random().Next(0, someNames.Length)],new Random().Next(18,60),new Random().Next(100,1500)));
            }
            return personList;
        }
    }
}
