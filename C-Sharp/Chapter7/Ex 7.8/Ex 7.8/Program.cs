using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter KM driven: ");
            decimal numKm = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes waited: ");
            decimal minWaited = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Total fare is: {FindCabFare(numKm, minWaited):C}");

        }

        static decimal FindCabFare(decimal numKm, decimal minWaited)
        {
            decimal minFare = 13.00M;
            decimal kmFare = 1.68M;
            decimal waitFare = 30.00M;

            decimal totalFare = minFare + (Math.Ceiling(numKm) * kmFare) + (waitFare / minWaited);

            return totalFare;



        }
    }
}
