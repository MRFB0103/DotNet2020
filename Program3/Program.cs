using System;

namespace Program3
{
    class Program
    {
        public static string BinaryToDecimal(string Binary)
        {
            int Decimal = 0, temp, i = 0;
            int binaryno = int.Parse(Binary);
            while (binaryno > 0)
            {
                temp = (binaryno % 10);
                Decimal = Decimal + (temp * (int)Math.Pow(2, i));
                i++;
                binaryno = binaryno / 10;
            }
            string Result = $"Binary : {Binary} is converted to Decimal: {Decimal}";
            return Result;
        }


        public static string DecimalToBinary(int decimalNo)
        {
            string Result = $"Decimal : {decimalNo} is converted to Binary: ";
            int value = decimalNo; int i;
            int[] binaryString = new int[10];
            for (i = 0; value > 0; i++)
            {
                binaryString[i] = (value % 2);
                value = value / 2;
            }
            i--;
            for (; i >= 0; i--)
            {
                Result += binaryString[i].ToString();
            }
            return Result;
        }

        public static string DecimalToOctal(int decimalNo)
        {
            string Result = $"Decimal : {decimalNo} is converted to Octal: ";
            int value = decimalNo; int i;
            int[] octalString = new int[10];
            for (i = 0; value > 0; i++)
            {
                octalString[i] = (value % 8);
                value = value / 8;
            }
            i--;
            for (; i >= 0; i--)
            {
                Result += octalString[i].ToString();
            }
            return Result;
        }


        public static string DecimalToHexadecimal(int decimalNo)
        {
            string Result = $"Decimal : {decimalNo} is converted to Hexadecimal: ";
            int value = decimalNo; int i;
            int[] hexadecimalString = new int[10];
            for (i = 0; value > 0; i++)
            {
                hexadecimalString[i] = (value % 16);
                value /= 16;
            }
            i--;
            for (; i >= 0; i--)
            {
                switch (hexadecimalString[i])
                {
                    case 10: Result += "A"; break;
                    case 11: Result += "B"; break;
                    case 12: Result += "C"; break;
                    case 13: Result += "D"; break;
                    case 14: Result += "E"; break;
                    case 15: Result += "F"; break;
                    default: Result += hexadecimalString[i].ToString(); break;
                }
            }
            return Result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BinaryToDecimal("1000"));
            Console.WriteLine(DecimalToBinary(8));
            Console.WriteLine(DecimalToOctal(16));
            Console.WriteLine(DecimalToHexadecimal(16));

            Console.ReadLine();
        }

    }
}
