using System;

namespace Chapter_3_exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // Comment: App that will spit out the product of three integers

            int x, y, z, result;

            Console.WriteLine("Enter the first INT value");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second INT value");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third INT value");
            z = int.Parse(Console.ReadLine());

            result = x * y * z;

            Console.WriteLine($"The product is {result}");

            Console.ReadLine();

        }
    }
}
