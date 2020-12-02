using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

    /* Write a method that replaces every letter 'y' in the string with 'x'. Assume that string contains only lower case letters.

            Expected input and output
            BEReplace("yellow") → "xellow"
            BEReplace("mushroom") → "mushroom”  */

            Console.WriteLine(BEReplace("yellow"));  // "xellow"
            Console.WriteLine(BEReplace("mushroom")); // "mushroom"
        }

        static string BEReplace(string s){

                return s.Replace('y','x');
        }



    }
}
