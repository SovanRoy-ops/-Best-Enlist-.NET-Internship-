using System;

namespace Task1
{
    class Program
    {


        /* Given a string, write a method that counts its number of words. Assume there are no leading and trailing whitespaces and there is only single whitespace between two consecutive words.
Expected input and output -NumberOfWords("This is sample sentence") → 4 (output)
NumberOfWords("OK") → 1(output)  */



        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfWords("Hii! this is a sentence!"));  //5
        }



        static int NumberOfWords(string s){
            
            int count = 0;
            string[] words = s.Split(" ");
            foreach (string word in words)
                 {
                    count++;
                }
                return count;
        }



    }
}
