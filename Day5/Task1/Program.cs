using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Given two different arithmetic operations (addition, substraction, multiplication, division), write a method that checks if they return the same result.
Expected input and output
CheckResult(2+2, 2*2) → true (CheckResult is your method name)
CheckResult(9/3, 16-1) → false   */
              
               Console.WriteLine(CheckResult(Operation(),Operation()));

         }

         static int Operation(){
            
                int firstNum;
                int secondNum;                   
               

                Console.Write("Enter the first number in your basic equation: ");
                firstNum = Convert.ToInt32(Console.ReadLine());                             

               
                Console.Write("Now enter your second number in the basic equation: ");
                secondNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ok now enter your operation ( x , / , +, -) ");
                operation = Console.ReadLine();

                if (operation == "x")
                {
                   return firstNum * secondNum;
                   
                }
                else if (operation == "/")
                {
                   return firstNum / secondNum;
                   
                }                                                                           
                
                else if (operation == "+")
                {
                   return firstNum + secondNum;
                  
                }
                else if (operation == "-")
                {
                   return firstNum - secondNum;
                   
                }
                else
                {
                   return 0; 
                }
         }

         static bool CheckResult(int a,int b){
             return a==b;
         }
    }
}
