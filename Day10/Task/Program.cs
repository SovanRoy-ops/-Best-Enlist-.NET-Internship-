using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

        /* Create a Calculator Console Application which takes input from user perform calculation and returns the value
	
Display the following Options when you run the program initially

Choose what operation what do you want to do 
1.addition
2.subtratcion
3.multiplication
4. division
5. Exit

if user press 1 ask them to enter 2 values

please enter your first value (after enter ask to enter 2nd value)
5

please enter your second value
5

display the output after add

output - 10
then ask them to enter 9 if the want to see other calculation option, if they enter then display the options 

 */

           Calculator();
        }

        static void Calculator(){

            Console.WriteLine("1.addition \n2.subtratcion \n3.multiplication \n4.division \n5.Exit\n\n");

            int user_choice,temp;
            float n1,n2;

            Console.Write("Choose the operation you want to perform: ");
            user_choice = Convert.ToInt32(Console.ReadLine());

            switch (user_choice){

                 case 1:                     
                        Console.Write("Enter your first number: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter your second number: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine($"The Result: {n1+n2}\n\n");
                        
                        Console.Write("Enter 9 if you want to perform another operation or 0 to exit...");
                        temp = Convert.ToInt32(Console.ReadLine());
                        
                        if(temp==9){
                            Calculator();
                        }
                        else if(temp==0){
                            Environment.Exit(0);
                        }
                        break;
                        
                        
                case 2:

                       Console.Write("Enter your first number: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter your second number: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine($"The Result: {n1-n2}\n\n");
                        
                        Console.Write("Enter 9 if you want to perform another operation or 0 to exit...");
                        temp = Convert.ToInt32(Console.ReadLine());
                        
                        if(temp==9){
                            Calculator();
                        }
                        else if(temp==0){
                            Environment.Exit(0);
                        }
                        break;  

                 case 3:

                      Console.Write("Enter your first number: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter your second number: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine($"The Result: {n1*n2}\n\n");
                        
                        Console.Write("Enter 9 if you want to perform another operation or 0 to exit...");
                        temp = Convert.ToInt32(Console.ReadLine());
                        
                        if(temp==9){
                            Calculator();
                        }
                        else if(temp==0){
                             Environment.Exit(0);
                        }
                        break;                   

                 case 4:

                      Console.Write("Enter your first number: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter your second number: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine($"The Result: {n1/n2}\n\n");
                        
                        Console.Write("Enter 9 if you want to perform another operation or 0 to exit...");
                        temp = Convert.ToInt32(Console.ReadLine());
                        
                        if(temp==9){
                            Calculator();
                        }
                        else if(temp==0){
                             Environment.Exit(0);
                        }
                        break; 

                    case 5:
                            Environment.Exit(0);
                            break;  

                default:
                        Console.WriteLine("Wrong input!");
                        Console.Write("Enter 9 if you want to perform another operation or 0 to exit...");
                        temp = Convert.ToInt32(Console.ReadLine());
                        
                        if(temp==9){
                            Calculator();
                        }
                        else if(temp==0){
                             Environment.Exit(0);
                        }
                        break;   

            }


        }


    }
}
