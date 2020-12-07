using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to find the prime numbers within a range of numbers
Test Data :Input starting number of range: 1Input ending number of range : 50Expected Output :The prime number between 1 and 50 are :2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
            */

            int flag  = 0;
            Console.Write("Enter the range: ");
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 2; i <= n; i++)
            {
                int j = 2;
                flag = 0;
                while(j<=(i/2))
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                    j++;
                }

                if(flag==0)
                    Console.Write(i + " ");

            }
            
        }
    }
}
