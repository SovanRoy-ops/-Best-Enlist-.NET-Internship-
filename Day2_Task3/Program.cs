using System;

namespace Day2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
          //3. To check the largest among three given numbers
            
            int x,y,z;
            Console.WriteLine("Enter three numbers:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            Console.Write("The Largest number is: ");

            if(x>y && x>z){
                Console.WriteLine(x);
            }
            else if(y>x && y>z){
                Console.WriteLine(y);
            }
            else{
                Console.WriteLine(z);
            }
        }
    }
}
