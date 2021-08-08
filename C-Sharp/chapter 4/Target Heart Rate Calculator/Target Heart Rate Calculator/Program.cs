using System;

namespace Target_Heart_Rate_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            HeartRates heartRate = new HeartRates();

            Console.WriteLine("Hello There!");
            Console.WriteLine("This little app will calculate your target heart rate");

            Console.WriteLine("Let's start by collecting some information about you.");

            Console.Write("\nPlease enter your name: ");
            string name = Console.ReadLine();
            Console.Write("\nPlease enter your birthyear: ");
            int birthyear = int.Parse(Console.ReadLine());

            heartRate.Birthyear = birthyear;
            heartRate.Name = name;

            Console.WriteLine("Your name is: " + heartRate.Name);
            Console.WriteLine("Your age is: " + heartRate.GetAge());
            Console.WriteLine("Your max heartrate is: " + heartRate.MaxHeartRate());
            Console.WriteLine("Your target heartrate is: " + heartRate.TargetHeartRate());


            
            Console.ReadLine();


        }
    }
}
