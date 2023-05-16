using System;

namespace Home9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonDataGenerator personDataGenerator = new PersonDataGenerator();
            AnalysePersonData analysePersonData = new AnalysePersonData();

            try
            {
                Person person = new Person("Ivan", 15, 2000);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
               Person person = new Person("Aleksandr", 34, 99);
            }
            catch (SalaryException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            var personList = personDataGenerator.GeneratePersonList(5);

            foreach(Person person in personList)
            {
                Console.WriteLine(person);
            }

            analysePersonData.ShowPersonWithNameStartsA(personList);

            analysePersonData.ShowYoungPersonWithBigSalary(personList);

            analysePersonData.ShowFirstOldMan(personList);
        }
    }
}