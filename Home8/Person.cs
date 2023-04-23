using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home8
{
    public class Person
    {
        public string Name { get; set; }
        public int MaxNumberOfCalories { get; set; }
        public Person(string name, int maxNumberOfCalories) 
        {
            Name = name;
            MaxNumberOfCalories = maxNumberOfCalories;
        }
        /// <summary>
        /// Method for check ration for person. Remove productd from list for day, if sum of calories more than MaxNumberOfCalories for person
        /// </summary>
        /// <param name="rationForSomePerson">ration</param>
        /// <param name="person">person</param>
        public void CheckAndUpdateRation(Dictionary<DayOfWeek, List<Product>> rationForSomePerson, Person person)
        {
            foreach (KeyValuePair<DayOfWeek, List<Product>> pair in rationForSomePerson)
            {
                int sumCalories = 0;
                foreach (Product product in pair.Value)
                {
                    sumCalories += product.NumberOfCalories;
                }
                if (sumCalories > person.MaxNumberOfCalories)
                {
                    do
                    {
                        Product productForDelete = pair.Value.First();
                        Console.WriteLine($"Remove. Day: {pair.Key}, product: {productForDelete}");
                        pair.Value.Remove(productForDelete);
                        sumCalories -= productForDelete.NumberOfCalories;
                    }
                    while(sumCalories > person.MaxNumberOfCalories);
                }
            }
        }
    }
}
