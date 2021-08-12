using System;

namespace Exercise_5._30_Rectangle_of_asterisks  // Note to self, "Rectangle of Asterisks" sounds like a fun band name .... 
{
    class Program
    {
        static void Main(string[] args)
        {
            // This app will create a rectangle of asterisks, with a size based on the user's input 
            // min width allowed = 1, max = 10 - min height allowed = 1, max = 15
            // If the values are outside the bounds, it will be set to the allowed min/max accordingly

        

            Console.WriteLine("Enter with of rectangle: ");
            int sizeWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of rectangle: ");
            int sizeHeight = int.Parse(Console.ReadLine());
            Console.Write("\n\n"); // Just inserts two blank lines


            // Sets upper and lower limits. Not very elegant, but it works
            if (sizeWidth < 1)
            {
                sizeWidth = 1;
            }
            if (sizeWidth > 10)
            {
                sizeWidth = 10;
            }

            if (sizeHeight < 1)
            {
                sizeHeight = 1;
            }
            if (sizeHeight > 15)
            {
                sizeHeight = 15;
            }
            

            
            for (int h=0; h < sizeHeight; h++)  // Draws each line of height
            {
                for(int w = 0; w < sizeWidth; w++) // Draws the width of the asterisks per line
                {
                    Console.Write("* ");
                }

                Console.Write("\n"); // inserts a Carriage Return

            }

            Console.Write("\n\n"); // inserts two blank lines, just to make everything look not smoshed together


            Console.WriteLine("Press ENTER to terminate....");
            Console.ReadLine(); // just the thing to prevent the console from closing


        }
    }
}
