using System;

namespace HealthRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            var healthProfile = new HealthProfile();

            Console.Write("\nEnter First Name: ");
            healthProfile.FirstName = Console.ReadLine();

            Console.Write("\nEnter Last Name: ");
            healthProfile.LastName = Console.ReadLine();

            Console.Write("\nEnter height in cm: ");
            healthProfile.Height = int.Parse(Console.ReadLine());

            Console.Write("\nEnter weight in KG: ");
            healthProfile.Weight = int.Parse(Console.ReadLine());

            Console.Write("\nEnter your birthyear: ");
            healthProfile.BirthdateYear = int.Parse(Console.ReadLine());
            
            Console.Write("\nEnter your birthmonth: ");
            healthProfile.BirthdateMonth = int.Parse(Console.ReadLine());

            Console.Write("\nEnter your birthday: ");
            healthProfile.BirthdateDay = int.Parse(Console.ReadLine());


            Console.WriteLine("\nThis is the data we can display based on your profile");
            Console.WriteLine("\nYour name is: " + healthProfile.FirstName + " " + healthProfile.LastName);
            Console.WriteLine("Your birthday is: " + healthProfile.BirthdateDay + "/" + healthProfile.BirthdateMonth + "/" + healthProfile.BirthdateYear);
            Console.WriteLine("Your age is: " + healthProfile.GetAge());
            Console.WriteLine("Your height is: " + healthProfile.Height / 100 + " meter");
            Console.WriteLine("Your weight is: " + healthProfile.Weight + " kg");
            Console.WriteLine("Your BMI is: " + String.Format("{0:0.00}", healthProfile.CalcBMI()));
            Console.WriteLine("Your max heartrate is: " + healthProfile.HeartrateMax());
            Console.WriteLine("Your target heartrate is in the range " + healthProfile.TargetHeartrateMin() + " to " + healthProfile.TargetHeartrateMax());

        }
    }
}
