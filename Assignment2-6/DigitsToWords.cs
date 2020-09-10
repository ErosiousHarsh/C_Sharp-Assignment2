using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2_6
{
    class DigitsToWords
    {
        String digitToWords(int n)
        {
            String[] ones = { "zer0", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            String[] tens = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty"};
            String[] others = { "hundered", "thousand", "lakh", "crore" };
            String final = "";

            int c = 0,t;
            t = n;
            while (n >= 10)
            {
                n /= 10;
                c++;
            }
            n = t;
            c += 1;

            int[] a = new int[c];
            c = 0;

            while(n >= 10)
            {
                a[c] = n % 10;
                n /= 10;
                c++;
            }
            a[c] = n;
            Array.Reverse(a);

            int last = a[a.Length - 1];
            int lastTwo = (a[a.Length - 2] * 10) + a[a.Length - 1];
            int firstTwo = (a[0] * 10) + a[1];
            int second = a[1];


            if ((lastTwo >= 11 && lastTwo <= 19) || (firstTwo >=11 && firstTwo <=19))
            {
                
                String[] spc = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen" };
                
                if (a.Length == 1)
                    final = ones[a[0]];
                else if (a.Length == 2)
                    final = spc[last];
                else if (a.Length == 3)
                    final = ones[a[0]] + " " + others[0] + " " + spc[last];
                else if (a.Length == 4)
                    final = ones[a[0]] + " " + others[1] + " " + ones[a[1]] + " " + others[0] + " " + tens[a[2]] + " " + ones[a[3]];
                else if (a.Length == 5)
                    final = spc[last] + " " + others[2] + " " + ones[a[1]] + " " + others[0] + " " + spc[last];

                return final;
            }

            if (a.Length == 1)
                final = ones[a[0]];
            else if (a.Length == 2)
                final = tens[0] + " " + ones[1];
            else if (a.Length == 3)
                final = ones[a[0]] + " " + others[0] + " " + tens[a[1]] + " " + ones[a[2]];
            else if (a.Length == 4)
                final = ones[a[0]] + " " + others[1] + " " + ones[a[1]] + " " + others[0] + " " + tens[a[2]] + " " + ones[a[3]];
            else if (a.Length == 5)
                final = ones[a[0]] + " " + others[2] + " " + ones[a[1]] + " " + others[1] + " " + tens[a[2]] + " " + ones[a[3]];

            return final;
            
        }
        static void Main(string[] args)
        {
            DigitsToWords dg = new DigitsToWords();

            int n;

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + dg.digitToWords(n));

            Console.ReadLine();

        }
    }
}
