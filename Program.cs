/*
Author: John Vicencio
Description: Method that adds the digits of an integer. In this scenario, 
display sumation that is equal to 10, else show the numbers that do not 
equal to 10. For example, if var num = 19, '1' plus '9' is ten. Otherwise 
simply return the integer.
Algorithm:
1. Create a method that takes an integer: convert the integer into 
string to parse as char.
2. Assign an integer as an argument to the method
3. Loop through up to value of integer
4. Call the method that displays either by summation of the digits or simply displaying those integerse that do not add to 10
*/

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace johnvicencio.numberpairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assign an integer and intialize variables
            int num = 28;
            string result = "";
            string notFound = "";

            //Loop up to the num integer
            //Each iteration call GetPairsSum method
            //Collect returned result from GetPairsSum
            //Display those matched integer equal to 10 
            //And those that were not matched
            for (int i = num; i > 0; i--)
            {
                string search = GetPairsSum(i);
                if(search.Contains("Match") == true)
                {
                    result += search + "\n";
                }
                else 
                {

                    if (i == 1)
                    {
                        notFound += "1";
                    }
                    else
                    {
                        notFound += search + ",";
                    }
                }
            }

            //Display matched and no matching results
            Console.WriteLine($"{result}\nNo match found for:\n\n{notFound}");
           
        }

        //Display the sum of first and second digits from a number
        static string GetPairsSum(int n)
        {
            // Variable assignments and initializetions
            string nums = Convert.ToString(n);
            int sum = 0;
            string result = "";

            //Converteach digits from each characgters of string 
            //And add digits togeter into integer
            foreach (char num in nums)
            {
                sum += (int)Char.GetNumericValue(num);

            }

            //Get result if summation of two digits is equals to 10
            //Or get the integer if not
            if (sum == 10)
            {
                result = $"Match found for {n}: ({nums[0]},{nums[1]})";
            }
            else
            {
                result = $"{nums}";
            }

            //Return result
            return result;
        }


    }
}