using System;
using System.Text.RegularExpressions;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, country;

            do
            {
                Console.WriteLine("Hello,Enter your Name:");
                name = Console.ReadLine();
            } while (!(Regex.IsMatch(name, "^[a-zA-Z]+$")));

            do
            {
                Console.WriteLine("Where are you from :");
                country = Console.ReadLine();
            } while (!(Regex.IsMatch(country, "^[a-zA-Z]+$")));

            Console.WriteLine();
            Console.WriteLine($"Hello {name} from country {country}");
            Console.Read();
        }
    }
}
