using System;

namespace HEX_TO_DEC
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] hex = Console.ReadLine().ToCharArray();

            for (int i = 0; i < hex.Length / 2; i++)
            {
                var tmp = hex[i];
                hex[i] = hex[hex.Length - i - 1];
                hex[hex.Length - i - 1] = tmp;
            }


            double br = 0;
            double a = 0;
            int num = 0;


            foreach (char symb in hex)
            {
                switch (symb)
                {
                    case '1': num = 1; break;
                    case '2': num = 2; break;
                    case '3': num = 3; break;
                    case '4': num = 4; break;
                    case '5': num = 5; break;
                    case '6': num = 6; break;
                    case '7': num = 7; break;
                    case '8': num = 8; break;
                    case '9': num = 9; break;
                    case 'A': num = 10; break;
                    case 'B': num = 11; break;
                    case 'C': num = 12; break;
                    case 'D': num = 13; break;
                    case 'E': num = 14; break;
                    case 'F': num = 15; break;
                    case '0': num = 0; break;
                }
                a += num * Math.Pow(16, br);
                br++;
            }
            Console.WriteLine(a);
        }
    }
}
