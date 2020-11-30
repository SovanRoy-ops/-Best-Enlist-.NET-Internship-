using System;
using System.Collections; 

namespace Task3
{
    class Program
    {
      
            // Given three letter long string, write a method that checks if at least one neighbour of middle letter is its neighbour in the alphabet.
        


         static bool Check(string s) 
    { 
  
        int l = s.Length; 
        bool flag = false;
        
        Array.Sort(s.Split()); 
  
        for (int i = 1; i < l; i++) { 
  
            
            if (s[i] - s[i - 1] == 1){
                flag = true;
            } 
                 
        } 
  
        return flag; 
    } 
  
    
    public static void Main() 
    { 
  
        
        string str = "dcef"; 
        Console.WriteLine(Check(str));
        
      
    }
  } 
}
