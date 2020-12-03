using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers is greater than third one.
            Expected input and output
            CheckGreaterNumber([2, 7, 12]) → true
            CheckGreaterNumber([-5, -8, 50]) → false
            */


            Console.WriteLine(CheckGreaterNumber(new int[] {2, 7, 12}));  // True
            Console.WriteLine(CheckGreaterNumber(new int[] {-5, -8, 50}));   // False
        }


        static bool CheckGreaterNumber(int[] arr){

                return (arr[0]+arr[1]>arr[2] || arr[0]*arr[1]>arr[2]);

        }


    }
}
