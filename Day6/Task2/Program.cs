using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {


            /* Given a string, write a method that checks if it is a palindrome. String length may be >= 0.

Expected input and output IsPalindrome("tat") → true IsPalindrome("hello") → false
            */



            Console.WriteLine(IsPalindrome("tat"));  // true
             Console.WriteLine(IsPalindrome("hello")); // false
        }


        static bool IsPalindrome(string s){

            string revs ="";

           for (int i = s.Length-1; i >=0; i--) 
            {  
                revs += s[i].ToString();  
            }  
         
         
         
            return (revs == s);
          
           



        }



    }
}
