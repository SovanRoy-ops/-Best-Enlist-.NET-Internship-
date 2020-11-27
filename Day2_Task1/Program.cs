using System;

namespace Day2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
             //1. WAP to find the sum of two integer values and if the two values are same return triple their sum. 

            Console.WriteLine("Enter your the numbers:");
            int sum =0;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if(a == b){
                sum = (a+b) * 3;
                Console.WriteLine("sum= " + sum);
            }
            else{
                sum = a+b;
                Console.WriteLine("sum= " + sum);
            }
        }
    }
}
