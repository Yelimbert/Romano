using System;
using System.Text;

namespace decToRom
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static string decimal_to_roman(int n)
        {
            string[] romanNumbers = {"MMM", "MM", "M", "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C", "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X", "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };
            int[] decimalNumbers = {3000, 2000, 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

            var roman = new StringBuilder();
            var i = 0;
            while(n != 0)
            {
                if (n >= decimalNumbers[i])
                {
                    n -= decimalNumbers[i];
                    roman.Append(romanNumbers[i]);
                }
                else
                {
                    i++;
                }
            }

            return roman.ToString();
        }
    }
}
