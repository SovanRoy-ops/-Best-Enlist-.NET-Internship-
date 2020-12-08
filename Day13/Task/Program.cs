using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a C# program that asks the user for a range of numbers (x, y) and displays the multiplication tables from x to y. */

            Console.Write("Enter the range of numbers: ");
            int x=int.Parse(Console.ReadLine());
            int y=int.Parse(Console.ReadLine());

            MultiTables(x,y);
        }

        static void MultiTables(int a,int b){

            for(int i=a;i<=b;i++){
                Console.WriteLine("Multiplication table for {0}\n",i);
                for(int j=1;j<=10;j++){
                    Console.WriteLine($"{i} X {j} = {i*j}");
                }
               Console.WriteLine();
            }

        }

    }
}
