using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

        /* Write a c# program to achieve operator overloading */

        bank ba1 = new bank(10,-20);
        ba1.display();
        bank ba2 = new bank();
        ba2.display(); 
        ba2 = -ba1;
        ba2.display();
        Console.ReadLine();
        }
    }

    class bank
{
     int x;
     int y;
    public bank(int a, int b)
    {
        x = a;
        y = b;
    }
    public bank()
    {   
    }
    public void display()
    {
        Console.Write(" " + x);
        Console.Write(" " + y);
        Console.WriteLine();
    }
    public static bank operator -(bank b)
    {
        b.x = -b.x;
        b.y = -b.y;
        return b;
    }
}
}
