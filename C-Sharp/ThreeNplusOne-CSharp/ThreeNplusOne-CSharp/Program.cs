using System;

namespace ThreeNplusOne_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3xPlusOne counter");

            Console.WriteLine("Enter Start Number:");
            int startNum = int.Parse(Console.ReadLine()); // asks which number you want to start with

            Console.WriteLine("Enter the desired number of iterations"); // Asks how many iterations 
            int numIterations = int.Parse(Console.ReadLine());

            for (int x = startNum; x <= startNum + numIterations; x++) // will loop x amount of times
            {
                int i = DoTheCalculation(x); // Calls the function/method

                Console.WriteLine(x + " " + i); // Should be fairly self explanatory... Writes the result to the console.
            }
        }

        static int DoTheCalculation(int n) 
            // This function/method will do the actual calculation of the 3n+1 problem, and return the number of iterations 
            // reached before reaching the final loop (1 2 4). 
        {
            int i = 0;
            while (n != 1)  // Checks to see if final loop is reached (if n=1, we know we reached the end loop)
                {
                    if (n % 2 == 0) // checks to see if number is even
                    {
                        n = n / 2;  // If number is even, divide by 2
                    }
                    else
                    {
                        n = (n * 3) + 1; // if number is odd, multiply by 3 and add 1
                    }

                i++; // increase iteration counter by one
                }

            return i; // returns the number of iterations 
        }
    } 
}