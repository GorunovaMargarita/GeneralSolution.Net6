using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home10
{
//    Реализовать паттерн наблюдатель в случае если цена на жилье опустилась ниже определенного значения, и сообщить всем кто на это событие подписался.
//* реализовать как через событие
    public class Task3
    {
        public static void Run()
        {
            PriceCenter priceCenter = new PriceCenter();
            AleksanderRealEstateAgency aleksander = new AleksanderRealEstateAgency();

            priceCenter.notify += aleksander.ShowMessage;

            priceCenter.GeneratePrice();
        }
    }
}
