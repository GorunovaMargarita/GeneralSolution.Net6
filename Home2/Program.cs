using System;


namespace Home2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConsoleCalculator();
            //Interval();
            //Transtlater();
            Parity();
        }
        public static void ConsoleCalculator()
        {
            double operand1 = 5;
            double operand2 = 90;
            double result;
            Console.WriteLine($"We have to numbers:{operand1} and {operand2}. \n Enter the sign of the arithmetic operation.");
            string sign = Console.ReadLine();
            if (operand2 == 0 && (sign.Equals(":") || sign.Equals("\\") || sign.Equals("/")))
                Console.WriteLine($"Division by zero is not possible.");
            else
            {
                switch (sign)
                {
                    case "-":
                        result = operand1 - operand2;
                        Console.WriteLine($"Result of your operation: {result}");
                        break;
                    case "+":
                        result = operand1 + operand2;
                        Console.WriteLine($"Result of your operation: {result}");
                        break;
                    case "*":
                        result = operand1 * operand2;
                        Console.WriteLine($"Result of your operation: {result}");
                        break;
                    case ":":
                    case "\\":
                    case "/":
                        result = operand1 / operand2;
                        Console.WriteLine($"Result of your operation: {result}");
                        break;
                    default:
                        Console.WriteLine("Unknown operation!");
                        break;
                }
            }
            Console.WriteLine("Please, enter any for close.");
            Console.ReadLine();
        }
        public static void Interval()
        {
            int border1 = 0;
            int border2 = 15;
            int border3 = 36;
            int border4 = 51;
            int border5 = 101;
            int number;
            bool needToContinue = true;
            do
            {
                Console.WriteLine("Please, enter your number.");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= border1 && number < border2)
                        Console.WriteLine($"Your number from interval {border1} - {border2 - 1}");
                    else if (number >= border2 && number < border3)
                        Console.WriteLine($"Your number from interval {border2} - {border3 - 1}");
                    else if (number >= border3 && number < border4)
                        Console.WriteLine($"Your number from interval {border3} - {border4 - 1}");
                    else if (number >= border4 && number < border5)
                        Console.WriteLine($"Your number from interval {border4} - {border5 - 1}");
                    else
                        Console.WriteLine("No interval for number");
                }
                else
                    Console.WriteLine("It't not a number. Please, try again.");
                Console.WriteLine("Enter Y for continue checking numbers");
                if (!string.Equals(Console.ReadLine(), "Y", StringComparison.OrdinalIgnoreCase))
                    needToContinue = false;
            }
            while (needToContinue == true);
        }
        public static void Transtlater()
        {
            Console.WriteLine("Please, enter your word in russian.");
            string word = Console.ReadLine();
            switch(word)
            {
                case "погода":
                    Console.WriteLine("Translate: weather");
                    break;
                case "ветер":
                    Console.WriteLine("Translate: wind");
                    break;
                case "солнце":
                    Console.WriteLine("Translate: sun");
                    break;
                case "облако":
                    Console.WriteLine("Translate: cloud");
                    break;
                case "влажность":
                    Console.WriteLine("Translate: wetness");
                    break;
                case "давление":
                    Console.WriteLine("Translate: pressure");
                    break;
                case "дождь":
                    Console.WriteLine("Translate: rain");
                    break;
                case "снег":
                    Console.WriteLine("Translate: snow");
                    break;
                case "луна":
                    Console.WriteLine("Translate: moon");
                    break;
                case "туман":
                    Console.WriteLine("Translate: fog");
                    break;
                default:
                    Console.WriteLine("Unknown word");
                    break;
            }
        }
        public static void Parity()
        {
            Console.WriteLine("Please, enter your number");
            double number;
            if (Double.TryParse(Console.ReadLine(), out number))
            {
                if (number % 2.0 == 0)
                    Console.WriteLine("It is a parity number.");
                else
                    Console.WriteLine("It is a odd number.");
            }
            else
                Console.WriteLine("It is not a number.");

        }
    }
}
