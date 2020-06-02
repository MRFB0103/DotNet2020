using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            float rupees, dollor, frank, euro;

            Console.Write("Enter amount in INR: ");
            rupees = float.Parse(Console.ReadLine());

            Console.WriteLine("INR to Dollar :" + rupees / 70.1);
            Console.WriteLine("INR to Frank :" + rupees / 73.28);
            Console.WriteLine("INR to Euro :" + rupees / 77.73);
            Console.Read();
        }
    }
}
