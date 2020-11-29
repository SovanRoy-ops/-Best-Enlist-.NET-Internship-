using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Create a function that takes an age in years and returns the age in days
            int age;
            Console.Write("Enter the age in years: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("The age converted in days: {0} days" ,Age_Converter(age));
        }

        static int Age_Converter(int age){
            int new_age = age*365;

            return new_age;
        }
    }
}
