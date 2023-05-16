using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9
{
    public class AnalysePersonData
    {
        public void ShowPersonWithNameStartsA(List<Person> personList)
        {
            var pesonStartsWithA = personList.Where(person => person.Name.StartsWith("А"));
            if(pesonStartsWithA.Count() > 0)
            {
                Console.WriteLine($"\nWe have {pesonStartsWithA.Count()} persons whose name starts with A:\n");
                foreach (Person person in pesonStartsWithA)
                {
                    Console.WriteLine(person);
                }
            }
            else 
            {
                Console.WriteLine("\nWe have no person whose name starts with A.\n");
            };
        }
        public void ShowYoungPersonWithBigSalary(List<Person> personList)
        {
            var persons = personList.Where(person => person.Age < 30 && person.Salary > 1000);
            if(persons.Count() > 0)
            {
                Console.WriteLine($"\nWe have {persons.Count()} persons with Age < 30 and Salary > 1000:\n");
                foreach (Person person in persons)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("\nWe have no personwith Age < 30 and Salary > 1000.\n");
            };
        }
        public void ShowFirstOldMan(List<Person> personList)
        {
            var oldMans = personList.Where(person => person.Age > 50);
            if(oldMans.Count() > 0)
            {
                Console.WriteLine($"\nFirst person older than 50 years is: {oldMans.First()}\n");
            }
            else
            {
                Console.WriteLine("We have no person older 50 yesrs");
            }
        }
    }
}
