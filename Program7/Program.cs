using System;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            float c, f;
            Console.WriteLine("1. C to F : ");
            Console.WriteLine("2. F to C : ");
            Console.WriteLine("Choose Any one: ");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter temprature in Celsius(°C)");
                    c = float.Parse(Console.ReadLine());
                    f = c * 9 / 5 + 32;
                    Console.WriteLine($"Temprature in Fahrenheit(°F) is {f}");
                    break;
                case 2:
                    Console.WriteLine("Enter temprature in Fahrenheit(°F)");
                    f = float.Parse(Console.ReadLine());
                    c = (f - 32) * 5 / 9;
                    Console.WriteLine($"Temprature in Celsius(°C) is {c}");
                    break;
            }
            Console.Read();
        }
    }
}
