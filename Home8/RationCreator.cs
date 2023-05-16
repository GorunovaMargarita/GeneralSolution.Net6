using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home8
{
    public class RationCreator
    {
        /// <summary>
        /// Generate ration for person. Sum calories for a products for a day more than person.MaxNumberOfCalories
        /// </summary>
        /// <param name="person"></param>
        /// <returns>ration (dictionary)</returns>
        public Dictionary<DayOfWeek, List<Product>> NewRation(Person person)
        {
            Dictionary<DayOfWeek, List<Product>> ration = new Dictionary<DayOfWeek, List<Product>>();
            foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
            {
                ration[dayOfWeek] = ListProductsForDay(person);
            }
            return ration;
        }
        public static void ShowRation(Dictionary<DayOfWeek, List<Product>> rationForSomePerson)
        {
            Console.WriteLine("\n Ration for a week: \n");
            foreach (KeyValuePair<DayOfWeek, List<Product>> pair in rationForSomePerson)
            {
                Console.WriteLine($"Day: {pair.Key}, product list:");
                foreach (Product product in pair.Value)
                {
                    Console.WriteLine($"{product}");
                }
                Console.WriteLine("________________");
            }
        }
        private List<Product> ListProductsForDay(Person person)
        {
            List<Product> productList = new List<Product>();
            int sumCaloriesByDay = 0;
            do
            {
                Product addingProduct = productForRation[new Random().Next(productForRation.Count)];
                productList.Add(addingProduct);
                sumCaloriesByDay += addingProduct.NumberOfCalories;
            }
            while (sumCaloriesByDay <= person.MaxNumberOfCalories);
            return productList;
        }
        List<Product> productForRation = new List<Product>()
        {
            new Product("carrot",200),
            new Product("cabbage",100),
            new Product("cucumber",50),
            new Product("tomato",100),
            new Product("potatoes",400),
            new Product("onion",50),
            new Product("garlic",50),
            new Product("spinach",50),
            new Product("banana",300),
            new Product("apple",100),
            new Product("peach",200),
            new Product("pineapple",200),
            new Product("kiwi",150),
            new Product("pear",200),
            new Product("milk",300),
            new Product("yoghurt",300),
            new Product("peas",100),
            new Product("soya beans",300),
            new Product("cream",500),
            new Product("cheese",400),
            new Product("bisquits",400),
            new Product("courgette",150),
            new Product("corn",200),
            new Product("wheat",200),
            new Product("oats",200),
            new Product("chicken",300),
            new Product("duck",400),
            new Product("beef",400),
            new Product("lamb",400),
            new Product("fish",300),
            new Product("shrimps",200),
            new Product("mussels",200),
            new Product("lobster",200)
        };
    }
}
