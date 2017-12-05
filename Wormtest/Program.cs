using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var wormLength = long.Parse(Console.ReadLine());
            var wormWidth = double.Parse(Console.ReadLine());

            var convertToCm = wormLength * 100.0;

            var reminder = convertToCm % wormWidth;

            if (reminder == 0 || wormWidth == 0)
            {
                var result = convertToCm * wormWidth;
                Console.WriteLine($"{result:f2}");
            }        
            else
            {
                double perc = (convertToCm / wormWidth) * 100;
                Console.WriteLine($"{perc:f2}%");
            }
           
        }
    }
}
