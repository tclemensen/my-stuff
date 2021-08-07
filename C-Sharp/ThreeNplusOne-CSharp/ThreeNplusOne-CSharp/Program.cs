using System;

namespace ThreeNplusOne_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3xPlusOne counter");

            Console.WriteLine("Enter Start Number:");
            int startNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the desired number of iterations");
            int numIterations = int.Parse(Console.ReadLine());

            for (int x = startNum; x <= startNum + numIterations; x++)
            {
                int i = DoTheCalculation(x); 

                Console.WriteLine(x + " " + i);
            }
        }

        static int DoTheCalculation(int n)
        {
            int i = 0;
            while (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = (n * 3) + 1;
                    }

                i++;
                }

            return i;            
        }
    } 
}