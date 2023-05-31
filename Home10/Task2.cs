using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home10
{
    public class Task2
    {
//        2. Реализовать паттерн наблюдатель в случае если цена на жилье опустилась ниже определенного значения, и сообщить всем кто на это событие подписался.
//     *  через паттерн наблюдатель без события
        public static void Run()
        {
            PriceCenter priceCenter = new PriceCenter();
            AleksanderRealEstateAgency aleksander = new AleksanderRealEstateAgency();
            MarinaRealEstateAgency marina = new MarinaRealEstateAgency();

            priceCenter.AddSubscriber(aleksander);
            priceCenter.AddSubscriber(marina);

            priceCenter.GeneratePrice();

            Console.WriteLine("\nThen we removed one agency\n");

            priceCenter.RemoveSubscriber(aleksander);

            priceCenter.GeneratePrice();
        }
    }
}
