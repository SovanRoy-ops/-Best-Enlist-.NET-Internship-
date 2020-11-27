using System;

namespace Day2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
     //2. WAP to check a given number and return true if it  is within 10 of 100 or 200
            
            int x;
            Console.WriteLine("Enter your  number:");
            x = Convert.ToInt32(Console.ReadLine());
           
            if(Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10) 
                {
                     Console.WriteLine("true");
                }
            else{
                 Console.WriteLine("false");
            }

        }
    }
}
