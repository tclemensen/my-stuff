using System;

namespace Ex_5._41___World_Growth_Estimator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Another fairly simple exercise this. Estimate the world's population over a period of 75 years
            // starting with the current figures and estimated yearly growth. 
            // At the time of writing (august 2021), the current population was approximately 7.9 billion, 
            // with a growth rate of 1.05% per year. This app is assuming that the growth rate will stay constant. 
            // We will also attempt to show at what point the poulation will be approximately DOUBLE of what it is today. 

            Console.WriteLine("Enter initial population value (Default=7.886.000.000): ");
            string inputPop = Console.ReadLine();

            if (inputPop == "")
            {
                inputPop = "7886000000";
            }
            double popInitial = double.Parse(inputPop);

            Console.WriteLine("Enter initial population growth rate (Default=1.05%): ");
            string inputGrow = Console.ReadLine();

            if (inputGrow == "")
            {
                inputGrow = "1.05";
            }
            double growthRate = double.Parse(inputGrow);                                           

            double popIncrease = 0;
            bool doubled = false;
            int yearDoubled = 0;
            
            // this is calculated in its simplest form -- Ideally this should probably be separated out into it's own class, but since
            // this is only used once and only here, and because I'm lazy, I will leave it in here. 

            for (int n = 1; n <= 75; n++)  // Will iterate 75 times
            {
                if (n <= 1) // Just displaying the inital value
                {
                    Console.WriteLine($"Year {n} -- Population: {popInitial:N0}");
                    popIncrease = popInitial;
                }

                popIncrease = popIncrease * growthRate; // calculating the per year increase
                Console.WriteLine($"Year: {n} -- Population: {popIncrease:N0}");

                
                // Checks to see the status of the "doubled" variable. If false, do a check to see if the current value of population has 
                // reached a point where the population is (at least) doubled compared to the initial value. 
                // If so, set the "doubled" variable to "true", to indicate the check is no longer performed, 
                // and store which year this happened in. 
                if (doubled == false) 
                {
                    if (popIncrease >= 2*popInitial)
                    {
                        yearDoubled = n;
                        doubled = true;
                    }
                }                
            }

            Console.WriteLine($"Population doubled in year {yearDoubled}");
        }

    }
}
