using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a string, write a method that checks if it consists atleast one uppercase letters.
            
            Console.Write("Enter the String: ");
            string s = Console.ReadLine();
            Console.WriteLine(StringChecker(s));

        }
        static bool StringChecker(string str){
            bool flag = false;

            for(int i=0;i<str.Length;i++){
                if(Char.IsUpper(str[i])){
                    flag = true;
                }
            }
            return flag;
        }
    }
}
