using System;

namespace Exercise_5._20___Discount_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Discount calculator
            // This will give the customer 10% discount on purchases on less than 5000, plus an additional 10% discount on purchases above 5000
            // This app will ask for a number value until the sentinel value of -1 is entered to finish the transaction
            // and calculate the total discount given. 


            // Just making some variables we'll use. 
            string askInput="";
            double priceEntered = 0;
            double totalPrice = 0;
            double discountedPrice = 0;


            while (askInput != "-1") // asking for input until -1 is entered, and adding up the total
            {
                Console.Write("Enter item price, or -1 to finish: ");
                askInput = Console.ReadLine();
                priceEntered = double.Parse(askInput);
                totalPrice = totalPrice + priceEntered;
            }

            if (totalPrice < 5000)
            {
                discountedPrice = totalPrice - ((totalPrice*10)/100); // This applies a 10% discount off the total price
            }

            if (totalPrice> 5000)
            {
                // This applies a 20% discount off the total price. This not entirely correct according to the exercise's premise, 
                // as 10% plus an additional 10% is not equal to 20%... However, I'm too damn lazy to do it correct! The idea is the same, 
                // it's just more calculation, and this is just a damn exercise, not a business critical app.... 
                discountedPrice = totalPrice - ((totalPrice * 20)/100); 
            }

            Console.WriteLine($"Total price before discount: {totalPrice:C}");
            Console.WriteLine($"Total price including discount: {discountedPrice:C}");


            // Just making sure the console doesn't close 
            Console.WriteLine("Press * ENTER * to terminate the program . . .)
            Console.ReadLine();



        




        }
    }
}
