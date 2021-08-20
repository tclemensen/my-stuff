using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex__7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sphere volume calculator. Will take a input and spit out the result
            // 
            Console.WriteLine("Enter sphere radius: ");
            double radius = double.Parse(Console.ReadLine());

            
            Console.WriteLine($"Sphere volume is {SphereVolume(radius):F3}");
            

        }

        // Calculates the sphere volume.
        static double SphereVolume(double radius) =>
            (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }

    
}
