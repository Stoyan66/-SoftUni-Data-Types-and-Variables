using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int sites = int.Parse(Console.ReadLine());
            int secKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;

            for (int i = 0; i < sites; i++)
            {
                string[] websites = Console.ReadLine().Split();

                var siteNames = websites[0];
                decimal siteVisits = decimal.Parse(websites[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(websites[2]);

                Console.WriteLine(siteNames);

                totalLoss += siteVisits * siteCommercialPricePerVisit;
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(secKey, sites)}");
        }
    }
}
