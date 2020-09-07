using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_4
{
    class PrimeNumber
    {
        int prime()
        {
            List<int> pNumber = new List<int>();

            int f = 0;
            for(int i=1; i<=500; i++)
            {
                for(int j=2; j<=i/2; j++)
                {
                    if(i%j == 0)
                    {
                        f = 1;
                        break;
                    }
                    f = 0;
                }
                if(f == 0)
                {
                    pNumber.Add(i);
                }

            }

            return (pNumber.Max(z => z));
        }
        static void Main(string[] args)
        {
            PrimeNumber pn = new PrimeNumber();

            Console.Write("Largest prime number between 1 & 500 is: " + pn.prime());

            Console.ReadLine();

        }
    }
}
