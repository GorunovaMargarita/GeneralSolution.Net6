using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public class DataGenerator
    {
        private static string[] someNames = new string[] { "Иван", "Олег", "Анна", "Денис", "Дарья", "Елена", "Максим", "Алексей", "Фёдор", "Мирон", "Наталья", "Николай", "Александр", "Марина" };
        private static string[] someLastNames = new string[] { "Коши", "Лагранж", "Пуанкаре", "Бессель", "Лаплас", "Лавуазье", "Максвелл", "Кюри" };

        public Cook Cook()
        {
            return new Cook(RandomArrayStringValue(someNames), RandomArrayStringValue(someLastNames), RandomDate(), RandomEnumValue<CookType>());
        }

        public Manager Manager()
        {
            return new Manager(RandomArrayStringValue(someNames), RandomArrayStringValue(someLastNames), RandomDate(), RandomEnumValue<ManagerType>());
        }
        public Cleaner Cleaner()
        {
            return new Cleaner(RandomArrayStringValue(someNames), RandomArrayStringValue(someLastNames), RandomDate());
        }
        private string RandomArrayStringValue(string[] array)
        {
            return array.GetValue(new Random().Next(0,array.Length)).ToString();
        }
        //нагугленное решение - типизируемый метод
        static T RandomEnumValue<T>()
        {
            var values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(new Random().Next(0,values.Length));
        }
        private static DateOnly RandomDate()
        {
            return DateOnly.FromDateTime(System.DateTime.Now.AddMonths(-new Random().Next(0, 12)));
        }
    }
}
