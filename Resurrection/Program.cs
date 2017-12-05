using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPhoenix = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfPhoenix; i++)
            {
                decimal bodyLentg = decimal.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                decimal wingLentgh = decimal.Parse(Console.ReadLine());

                decimal totalYears = (bodyLentg * bodyLentg) * ((wingLentgh * 2) + bodyWidth);

                Console.WriteLine($"{totalYears}");

            }
           
        }
    }
}
