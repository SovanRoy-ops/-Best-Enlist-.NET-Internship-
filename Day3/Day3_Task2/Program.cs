using System;

namespace Day3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program to read roll no, name and marks of three subjects and  calculate the total, percentage and division. 

            double role,phy,che,cs,total;
            double per_subj;
            string name,div;

            Console.Write("Input the Roll Number of the student :");
            role = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student :");
            name = Console.ReadLine();

            Console.Write("Input  the marks of Physics : ");
            phy= Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Computer Science : ");
            cs = Convert.ToInt32(Console.ReadLine());

            total = phy+che+cs;
            per_subj = total/3.0;
            if (per_subj>=60)
            div="First";
            else
            if (per_subj<60&&per_subj>=48)
                div="Second";
            else
                if (per_subj<48&&per_subj>=36)
                div="Pass";
                else
                div="Fail";

            Console.Write("\nRoll No : {0}\nName of Student : {1}\n",role,name);
            Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Science : {2}\n",phy,che,cs);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n",total,per_subj,div);
        }
                
     }
}
