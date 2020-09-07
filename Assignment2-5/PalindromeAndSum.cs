using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_5
{
    class PalindromeAndSum
    {
        void palinAndSum(int n)
        {
            int t,p, r = 0,s = 0;
            t = n;
            p = n;

            while(n != 0)
            {
                r = r * 10 + (n % 10);
                n /= 10;
            }

            while(p > 10)
            {
                s += p%10;
                p /= 10;
            }
            s += p;

            if(t == r)
                Console.WriteLine("\n\tPalindrome number\n");
            else
                Console.WriteLine("\nNot a Palindrome number\n");

            if (t == s)
                Console.WriteLine("\tSum of digits(" + s + ") " + "is equal to the number (" + t +")\n");
            else
                Console.WriteLine("\tSum of digits(" + s + ") " + "is not equal to the number (" + t + ")\n");
        }
        static void Main(string[] args)
        {
            PalindromeAndSum ps = new PalindromeAndSum();

            int n;

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            ps.palinAndSum(n);

            Console.ReadLine();
        }
    }
}
