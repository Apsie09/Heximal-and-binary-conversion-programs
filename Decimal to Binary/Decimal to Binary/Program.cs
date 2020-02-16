using System;

namespace Decimal_to_Binary
{
    class Program
    {
        static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Choose between Binary to Decimal or Decimal to Binary");
            Console.WriteLine("Binary to Decimal = 1");
            Console.WriteLine("Decimal to Binary = 0");
            Console.Write("Your choice:");
            string choice = Console.ReadLine();



            if (choice == "0")
            {
                Console.Write("Decimal number:");
                var num = int.Parse(Console.ReadLine());
                var a = "";

                while (num != 0)
                {
                    if (num % 2 == 0)
                    {
                        a += "0";
                        num /= 2;
                    }
                    else if (num % 2 == 1)
                    {
                        a += "1";
                        num /= 2;
                    }
                }
                Console.WriteLine("Binary number:" + Reverse(a));
            }

            if (choice == "1")
            {
                Console.Write("Binary number:");
                char[] dec = Console.ReadLine().ToCharArray();

                for (int i = 0; i < dec.Length / 2; i++)
                {
                    var tmp = dec[i];
                    dec[i] = dec[dec.Length - i - 1];
                    dec[dec.Length - i - 1] = tmp;
                }

                double br = 0;
                double a = 0;
                int num = 0;

                foreach (char symb in dec)
                {
                    switch (symb)
                    {
                        case '1': num = 1; break;
                        case '0': num = 0; break;
                    }
                    a += num * Math.Pow(2, br);
                    br++;
                }
                Console.WriteLine("Decimal number:" + a);
            }

            Console.WriteLine("Goodbye!");



        }
    }
}
