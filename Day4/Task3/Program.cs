using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a function that accepts a string of a person's first name and last name and returns a string with a person's first name and last name swapped
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("The changed name: {0}",String_Converter(name));
            

            }

            static string String_Converter(string name){
                string[] new_string = name.Split(" ");

                return new_string[1] + " " + new_string[0];
            }
    }
}
