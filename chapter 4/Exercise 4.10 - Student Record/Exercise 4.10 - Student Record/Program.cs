using System;

namespace Exercise_4._10___Student_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to student registration");
            Console.Write("/nEnter Student ID: ");
            string studentID = Console.ReadLine();
            Console.Write("/nEnter Student Name: ");
            string studentName = Console.ReadLine();
            Console.Write("/nEnter grade 1: ");
            decimal grade1 = decimal.Parse(Console.ReadLine());
            Console.Write("/nEnter grade 2: ");
            decimal grade2 = decimal.Parse(Console.ReadLine());
            Console.Write("/Enter grade 3: ");
            decimal grade3 = decimal.Parse(Console.ReadLine());

            StudentReg student1 = new StudentReg(studentID, studentName,grade1,grade2,grade3);

            Console.WriteLine(student1.Name + " " + student1.ID);
        }
    }
}
