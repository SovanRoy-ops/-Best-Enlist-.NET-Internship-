using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

        /* Write a program in C# Sharp to display the number in reverse order. Go to the editorTestData :Input a number: 12345Expected Output :The number in reverse order is : 54321 */


            int  n, reverse=0, rem;           
            Console.Write("Enter a number: ");      
            n = int.Parse(Console.ReadLine());     
            while(n!=0)      
                {      
                rem=n%10;        
                reverse=reverse*10+rem;      
                n/=10;      
                }      
            Console.Write("Reversed Number: "+reverse); 
        }
    }
}
