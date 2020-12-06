using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
          

         /* Write a C# program to answer about the statistical information such as arithmetic mean, median, mode, and standard deviation of an integer array */


             
        int n;
        float deviation, sum, sumsqr, mean, variance, stddev;
        
        Console.Write("Enter number of elements:");
        n = int.Parse(Console.ReadLine());
        float[] num = new float[n];
        sum = 0;
        sumsqr = 0;

        
        Console.WriteLine("Input " + n + " values");
        for (int i = 0; i < n; i++)
        {
            num[i] = float.Parse(Console.ReadLine());
            sum += num[i];

        }
        mean = sum / (float)n;
        Console.WriteLine("Mean is "+ mean);   // mean



        
        int maxCount=0;
        float maxValue=0;

        for (int i = 0; i < num.Length; ++i) {
            int count = 0;
            for (int j = 0; j < num.Length; ++j) {
                if (num[j] == num[i]) 
                    ++count;
            }
            if (count > maxCount) {
                maxCount = count;                      
                maxValue = num[i];
            }
        }

        Console.WriteLine("Mode is: "+maxValue);    // mode




        int middle = num.Length/2;
    if (num.Length%2 == 1) {
        Console.WriteLine("Median is: "+num[middle]);         // median
    } else {
        Console.WriteLine("Median is: "+((num[middle-1] + num[middle]) / 2.0));     
    }



        for (int i = 0; i < n; i++)
        {
            deviation = num[i] - mean;
            sumsqr += deviation * deviation;
        }      
        variance = sumsqr / (float)n;
        stddev = (float)Math.Sqrt(variance);
        Console.WriteLine("Standard Deviation is " + stddev);  // standard deviation 
        
        }
    }
}
