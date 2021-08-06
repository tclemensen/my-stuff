using System;

namespace ThreeNplusOne_CSharp
{
    class Program
    {        
        static void Main(string[] args)
        {
           
            int numIterations = 0;

            Console.WriteLine("3xPlusOne");

            myCalc(10);

            Console.WriteLine(numIterations);
        }

        public int myCalc(int x)
        {
            int numIterations = 0;
            while (x != 1)
            {
                if (x % 2 == 0)
                {
                    x = x / 2;
                }
                else
                {
                    x = (3 * x) + 1;
                }

                numIterations++;
            }
            return numIterations;
        }
    }
}
