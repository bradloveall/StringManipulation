using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcome();            
            while (true)
            {
                PrintInstructions();
                string method = Console.ReadLine();
                if (method != "0" && method != "1")
                {
                    PrintError();
                    continue;
                }                    

                PrintPleaseEnterString();                
                ReverseString(Console.ReadLine(), method);              
            }            
        }


        static void ReverseString(string input, string method)
        {
            if (method == "0")
                ReverseStringUsingArrayReverse(input);
            else if(method == "1")
                ReverseStringUsingStacks(input);
                
        }
       
        static void ReverseStringUsingStacks(string input)
        {
            StringManipulationUsingStacks obj = new StringManipulationUsingStacks();
            Console.WriteLine(String.Format("Here is your string: {0}", obj.GetReversedString(input)));
        }

        static void ReverseStringUsingArrayReverse(string input)
        {
            StringManipulationUsingArrayReverse obj = new StringManipulationUsingArrayReverse();
            Console.WriteLine(String.Format("Here is your string: {0}", obj.GetReversedString(input)));
        }

        #region Print Methods
        static void PrintError()
        {
            Console.WriteLine("YOU DIDN'T PLAY BY THE RULES!");
        }

        static void PrintWelcome()
        {
            Console.WriteLine("****Welcome to String Manipulation!****");
        }

        static void PrintInstructions()
        {
            Console.WriteLine("To reverse your string using Array.Reverse, enter 0. To reverse your string using stacks, enter 1.");
        }

        static void PrintPleaseEnterString()
        {
            Console.WriteLine("Please Enter a String to Reverse:");
        }
        #endregion        
    }
}
