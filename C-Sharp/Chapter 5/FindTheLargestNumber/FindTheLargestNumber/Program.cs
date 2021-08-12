using System;

namespace FindTheLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialising some variables
            int max=0;
            int min=0;
            int x=0;
            
            while ( x < 10) // Creating a loop. This can be written as a "for x..." loop also, but speed here is not critical here so I chose to use a while loop.
            {
                // Asking for inputs
                Console.Write("Please enter the " + x + " value to add: ");
                int value = int.Parse(Console.ReadLine());

                if (x <= 0) // setting initial value of the "min" variable to something if this is the first loop. If not, the "min" value will remain 0
                {
                    min = value;
                }

                if (value > max) // Checking to see if the variable "value" is bigger than the current "max" value stored, and updating if necessary.
                {
                    max = value;
                }

                if (value < min) // Almost exactly the same as above. I think you get the idea . . . 
                {
                    min = value;
                }

                x++;  // iterating
            }

            // Writing results to the console
            Console.WriteLine($"Max value entered was: {max}"); 
            Console.WriteLine($"Min value entered was: {min}");

            Console.ReadLine();  // just making sure the console doesn't close... 
          
        }
    }
}
