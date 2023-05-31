using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home10
{
    public class PriceCenter : ISubscriberable
    {
        public event Action<int> notify;

        List<ISubscriber> subscribers;
        public PriceCenter()
        {
            subscribers = new List<ISubscriber>();
        }
        public void AddSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void NotifySubscriber(int price)
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.ShowMessage(price);
            }
        }

        public void GeneratePrice()
        {
            Random rnd = new Random();
            for(int i = 1; i <= 10; i++)
            {
                var price = rnd.Next(5000000, 10000000);
                if (price < 7000000)
                {
                    NotifySubscriber(price);
                    notify?.Invoke(price);
                }
            }
        }
    }
}
