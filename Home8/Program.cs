using System;

namespace Home8 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person somePerson = new Person("Ivan", 1000);
            RationCreator creator = new RationCreator();

            Dictionary<DayOfWeek, List<Product>> rationForSomePerson = creator.NewRation(somePerson);

            RationCreator.ShowRation(rationForSomePerson);

            somePerson.CheckAndUpdateRation(rationForSomePerson, somePerson);
            
            RationCreator.ShowRation(rationForSomePerson);
        }
    }
}