using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int divided = n / 2;

            var count = 0;

            while (n >= m)
            {
                n -= m;
                count++;

                if (n == divided)
                {
                    if (y > 0)
                    {
                        n /= y;
                    }                   
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
            
            
        }
    }
}
