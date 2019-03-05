using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    
     
    
    static int solution(string str) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
       
        string[] multiArray = str.Split(new Char [] {'.', '!', '?' } ); 
        int max = 0; // word count 
        int OUT = 0; 
        int IN = 1;
        foreach (string S in multiArray)  
        {  
            int i = 0; 
            int state = OUT; 
            int c= 0;
            while (i < S.Length) 
            { 
                // If next character is a separator,  
                // set the state as OUT 
                if (S[i] == ' ' || S[i] == '\n'|| S[i] == '\t') 
                    state = OUT; 
                      
          
                // If next character is not a word  
                // separator and state is OUT, then  
                // set the state as IN and increment 
                // word count 
                else if (state == OUT) 
                { 
                    state = IN; 
                    ++c; 
                } 
          
                // Move to next character 
                ++i; 
            } 
            if(max<c)
              max =c;
        }  
         
        return max; 
    }
    

    public static void Main() 
    { 
        String str = "We test coders. Give us a try?";
        str = "Forget CVs..Save time . x x";
        int length = str.Length;
        if(length==0 || length >100){
            // end yaahiin uuruu shiideeree;
        }
        
        
        Console.WriteLine("No of words : "
                              + solution(str)); 
    } 
}