using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home10
{
    internal class AleksanderRealEstateAgency : ISubscriber
    {
        public void ShowMessage(int price)
        {
            Console.WriteLine($"New price {price}. Aleksander agents, please, ring your client.");
        }
    }
}
