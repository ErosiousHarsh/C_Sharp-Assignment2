using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class ArmstrongNumber
    {

        Boolean check(int n)
        {
            int t, r, c = 0;
            t = n;

            while(t != 0)
            {
                r = t % 10;
                c += (r * r * r);
                t /= 10;
            }

            if (c == n)
                return true;
            else
                return false;

        }
        static void Main(string[] args)
        {
            ArmstrongNumber an = new ArmstrongNumber();

            int n;

            Console.Write("Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (an.check(n))
                Console.WriteLine("\nArmstrong number");
            else
                Console.WriteLine("\nNot Armstrong number");

            Console.ReadLine();
        }
    }
}
