using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Write a C# program to demonstrate method overloading */

            int a=add(5,5);
            int b=add(5,5,5);
            double c=add(5.26,4.32,21.1,52.42);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        public static int add(int a, int b)  
        {    
        return a + b;    
        
        }    
        public static int add(int a, int b,int c) 
        {    
            return a + b + c;    
        
        }    
        public static double add(double a, double b,double c,double d) 
        {    
            return a + b + c + d;    
        
        }    



    }
}
