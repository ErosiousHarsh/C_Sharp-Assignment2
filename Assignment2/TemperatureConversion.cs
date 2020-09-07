using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TemperatureConversion
    {

        float convert(float tmp)
        {
            return (tmp * 9) / 5 + 32;
        }
        static void Main(string[] args)
        {
            TemperatureConversion tc = new TemperatureConversion();

            float tmp;

            Console.Write("Enter temperature in Celcius: ");
            tmp = Convert.ToSingle(Console.ReadLine());

            Console.Write("\n" + tmp + "° C in Fahrenheit is: " + tc.convert(tmp) + "F ");
            Console.ReadLine();
        }
    }
}
