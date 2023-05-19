using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home10
{
    public class Task1
    {
        //1. Cоздать класс мониторинга средней цен на жилье, цена будет генерироваться с помощью класса рандом и выдавать случайное значение в определенном диапазоне.Для того чтобы вывод цены был удобен пользователю в классе мониторинга создать поле делегат, обьект которого будет создаваться в классе мониторинга.Пользователь указывает метод для отображения цены в удобном ему формате путем передачи метода в конструктор класса мониторинга.
        public static void Run()
        {
            PriceMonitor monitor = new PriceMonitor(PriceMonitor.ShowPriceInRussian);
            var initialPrice = PriceMonitor.GeneratePrice();

            for (int i = 0; i < 10; i++)
            {
                var currentPrice = PriceMonitor.GeneratePrice();
                monitor.PriceAnalyse(currentPrice, initialPrice);
                initialPrice = currentPrice;
            }
        }
    }
}
