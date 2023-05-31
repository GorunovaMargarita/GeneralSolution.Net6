using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home10
{
    public class PriceMonitor
    {
        public delegate void ShowMessage(int price);
        ShowMessage showMessage { get; set; }

        public PriceMonitor(ShowMessage show) 
        {
            this.showMessage = show;
        }
        public static int GeneratePrice()
        {
            Random rnd = new Random();
            return rnd.Next(5000000, 10000000);
        }
        public void PriceAnalyse(int price, int initialPrice)
        {
           if (Math.Abs(price - initialPrice) > 1000000)
            {
                showMessage(price);
            }
        }
        public static void ShowPriceInEnglish(int price)
        {
            Console.WriteLine($"New price: {price} is more than previous on one million");
        }
        public static void ShowPriceInRussian(int price)
        {
            Console.WriteLine($"Novaya tsena: {price} eto na odin million bolee chem bylo");
        }
    }
}
