using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

        /*  Given a string, write a method that checks if each word in the string starts with lower case and if so, removes this letter from the string.
            Expected input and output
            CheckStringofLowercase("Hello React js") → "Hello React s"  */  


            CheckStringofLowercase("Hello React js");
        }

        static void CheckStringofLowercase(string s){

            string[] my_str = s.Split(" ");
                   
            for(int i=0;i<my_str.Length;i++){
                
                if(!Char.IsUpper(my_str[i], 0)){
                   
                    my_str[i]=my_str[i].Remove(0,1);

                }                  
            }
            Console.Write(string.Join(" ",my_str));    // Hello React s
        }
    }
}
