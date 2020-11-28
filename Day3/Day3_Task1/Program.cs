using System;

namespace Day3_Task1
{
    class Program
    {
       // 	Write a C# Sharp program to find whether a given year is a leap year or not. 
        static void Main(string[] args)
        {
            Console.Write("Enter Year : ");  
            int Year = int.Parse(Console.ReadLine());  
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) Console.WriteLine("{0} is a Leap Year.", Year);  
            else Console.WriteLine("{0} is not a Leap Year.", Year);  
             
        }
    }
}
