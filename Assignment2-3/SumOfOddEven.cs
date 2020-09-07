using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3
{
    class SumOfOddEven
    {

        int sumOdd()
        {
            int s=0;
            for(int i=1;i<=100;i+=2)
            {
                s += i;
            }

            return s;
        }
        int sumEven()
        {
            int s = 0;
            for (int i = 2; i <= 100; i += 2)
            {
                s += i;
            }

            return s;
        }

        static void Main(string[] args)
        {
            SumOfOddEven sm = new SumOfOddEven();

            Console.Write("\nSum of odd numbers from 1 to 100 is: " + sm.sumOdd());
            Console.Write("\nSum of even numbers from 1 to 100 is: " + sm.sumEven());

            Console.ReadLine();
        }
    }
}
