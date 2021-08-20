using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7._40
{
    class Program
    {
        static void Main()
        {
            int num1 = GetRandomForMultiplication();
            
            int num2 = GetRandomForMultiplication();


            Console.WriteLine($"What is {num1} * {num2} = ");
            int response = int.Parse(Console.ReadLine());

            CheckCorrectAnswer(num1, num2, response);

            Main();

        }

        static int GetRandomForMultiplication()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int number = rnd.Next(1, 11);
            
            return number;
        }

        static void CheckCorrectAnswer(int num1, int num2, int response)
        {
            string[] possibleResponsesCorrect = new string[] { "Very Good", "Excellent!", "Nice Work!", "Keep up the good work!" };
            string[] possibleResponsesWrong = new string[] { "No, please try again", "Wrong. Please try once more", "Don't give up!", "No, keep trying!" };

            Random rnd = new Random();
            int index = rnd.Next(4);

            if (response == num1 * num2)
            {
                Console.WriteLine($"{possibleResponsesCorrect[index]}");
            }
            else
            {
                Console.WriteLine($"{possibleResponsesWrong[index]}");
            }

        }
    }
}
