using System;
using Xunit;

namespace Assessment_Challenge_NAL
{
    public class Program
    {
        static bool Palindrome_Check(string myString){

           
            myString = myString.ToLower();
            Console.WriteLine(myString);
            myString = myString.Replace(" ", String.Empty);
            bool result = true;
            
        
            int f=0;
                for(int i = myString.Length-1; i >= 0; i = i-1) {       
            Console.WriteLine("Char at pos " + f + " : " + myString[f] + "\r\n" +"Char at pos " + i + " : " + myString[i]);
            if(myString[f] != myString[i]){result = false;}
            f = f+1;
            }
            Console.WriteLine(result);
            return result;
        }
       
       /* static void Main(string[] args)
        {  
            
            System.Console.WriteLine(Program.Palindrome_Check("NeVeR oDd Or EvEn"));
        }*/
    }
}
