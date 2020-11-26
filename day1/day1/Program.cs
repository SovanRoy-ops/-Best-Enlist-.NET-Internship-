using System;
using System.Collections.Generic;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Write a C# program to print hello and your name in a seperate line

            Console.WriteLine("Hello\nSovan!");

            // 2. Write a C# program to remove a specified character from a non empty string using the index of the character
            
            string s = "Hello";
            string s1=s.Remove(2,1);
            Console.WriteLine(s1);



            // 3. find the longest word in a string 


            string text;
            string[] stringList;
            int ni = 0, len, max = 0;
                     
            Console.Write("Enter a string :");
            text = Console.ReadLine();
            stringList = text.Split(' ');
            len = stringList.Length;
            
            //finding index of longest string
            for (int i = 0; i < len; i++)
            {
                if (stringList[i].Length > max)
                {
                    max = stringList[i].Length;
                    ni = i;
                }
            }

            //Output
            Console.WriteLine("Longest string: "+ stringList[ni]);
            Console.ReadLine();
        }
    }
}
