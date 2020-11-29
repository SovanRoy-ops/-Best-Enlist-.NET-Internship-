using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number(from 1 to 12) and returns its corresponding month name as a string.

            Console.Write("Enter the number of the month you want to see: ");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;

                 case 2:
                    Console.WriteLine("February");
                    break;

                 case 3:
                    Console.WriteLine("March");
                    break;

                 case 4:
                    Console.WriteLine("April");
                    break;

                 case 5:
                    Console.WriteLine("May");
                    break;

                 case 6:
                    Console.WriteLine("June");
                    break;

                 case 7:
                    Console.WriteLine("July");
                    break;

                 case 8:
                    Console.WriteLine("August");
                    break;

                 case 9:
                    Console.WriteLine("September");
                    break;

                 case 10:
                    Console.WriteLine("October");
                    break;

                 case 11:
                    Console.WriteLine("November");
                    break;

                 case 12:
                    Console.WriteLine("December");
                    break;

                 default:
                    Console.WriteLine("Sorry wrong input..try again!");
                    break;

               
            }
        }
    }
}
