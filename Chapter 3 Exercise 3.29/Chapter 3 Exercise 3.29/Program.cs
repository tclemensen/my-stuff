using System;

namespace Chapter_3_Exercise_3._29
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input start number:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{n} x {i} = " + Convert.ToString(n * i));
            }

            Console.ReadLine();

        }
    }
}
