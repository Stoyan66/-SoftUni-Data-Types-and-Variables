using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            decimal traveledDistance = decimal.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * traveledDistance;
            var hortnetFlaps = wingFlaps / 100;
            var rest = ((wingFlaps / endurance) * 5) + hortnetFlaps;


            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{rest} s.");
        }
    }
}
