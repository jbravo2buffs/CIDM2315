﻿namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for Q1
            Console.WriteLine("Enter a grade (A, B, C, D, F):");
            string grade = Console.ReadLine().ToUpper();
            switch (grade)
            {
                case "A":
                    Console.WriteLine("GPA: 4");
                    break;
                case "B":
                    Console.WriteLine("GPA: 3");
                    break;
                case "C":
                    Console.WriteLine("GPA: 2");
                    break;
                case "D":
                    Console.WriteLine("GPA: 1");
                    break;
                case "F":
                    Console.WriteLine("GPA: 0");
                    break;
                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    break;
            }

            // Code for Q2
            Console.WriteLine("Enter three numbers:");
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());
            int num3 = Convert.ToInt16(Console.ReadLine());

            int smallest = num1;
            if (num2 < smallest)
            {
                smallest = num2;
            }
            if (num3 < smallest)
            {
                smallest = num3;
            }
            
            Console.WriteLine("The smallest number is: " + smallest);

            // Code for Bonus question
            Console.WriteLine("Enter a year to check if it is a leap year:");
            int year = Convert.ToInt16(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}
