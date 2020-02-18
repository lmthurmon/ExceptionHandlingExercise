using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            // Create a list called numbers that will hold integers
            var test = new List<int>();
            // Create an string variable with an empty string initializer - name it str
            var str = "";

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()

            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            //TODO START HERE:

            // Make a foreach loop to iterate through your character array
            
            // Now create a try catch

            foreach (var num in arr)
            {
                try
                {
                    str = num.ToString();   
                    
                    test.Add(int.Parse(str));
                }
                catch (Exception )
                {
                    Console.WriteLine($"Unable to Parse '{num}'");
                }
            }
            
            foreach (var x in test)
            { Console.WriteLine(x); }

            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list

            // in your () of your catch, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
           // static void LoggerError(Exception)

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
}
