using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home10
{
    internal class MarinaRealEstateAgency : ISubscriber
    {
        public void ShowMessage(int price)
        {
            Console.WriteLine($"New price {price}. Marina agents, please, ring your client.");
        }
    }
}
