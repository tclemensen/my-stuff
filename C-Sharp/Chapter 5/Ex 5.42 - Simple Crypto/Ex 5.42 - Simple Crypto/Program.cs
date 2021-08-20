using System;

namespace Ex_5._42___Simple_Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            // (very) Simple crypto encoder:
            // This app will take a 4 digit integer
            // split it into it's individial numbers
            // add 7 to each of the numbers
            // divide by 10 and use the remainder
            // swap 1 and 3, and 2 and 4
            // display the result


            
            int[] ciferOutput = { 0, 0, 0, 0 };

            Console.WriteLine("Enter a 4 digit whole number; ");
            string ciferInput = Console.ReadLine();

            if (ciferInput.Length != 4)
            {
                Console.WriteLine("Invalid input, try again");
            }

            for (int n = 0; n < 4; n++)
            {
                int x = Convert.ToInt32(ciferInput[n]);

                x = x + 7;
                x = x % 10;

                ciferOutput[n] = x;

                Console.WriteLine(ciferOutput[n]);
            }

            string ciferComplete = Convert.ToString(ciferOutput[2]) + Convert.ToString(ciferOutput[3] + Convert.ToString(ciferOutput[0]) + Convert.ToString(ciferOutput[1]));
            
            Console.WriteLine($"Completed encryption: {ciferComplete:D4}");
        }


    }
}
