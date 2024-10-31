using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingChallengeConsoleCollection.PalindromeDetector
{
    public class Program
    {

        public static void Run()
        {

            Console.WriteLine("Welcome to your Palindrome Detection program!\n" +
                "Enter an alphanumeric string to find out if it's a palindrome, or enter \"0\" to exit the program\n");

            var input = Console.ReadLine();

            if (input == "0")
            {
                return;
            }    



            var result = PalindromeDetection(input);

            if (result)
            {
                Console.WriteLine($"Your word {input} IS a palindrome!");
            }
            else
            {
                Console.WriteLine($"Your word {input} is NOT a palindrome :(");
            }



            Console.WriteLine("Hit Enter to return to the main menu");
            Console.ReadLine();

        }



        public static bool PalindromeDetection(string input)
        {
            //Regex.Replace to search input, , ^ to negate, for alphanumeric characters, and replace non alphanumerics with nothing, then set all to lower 
            string cleanInput = Regex.Replace(input, "[^a-zA-Z0-9]", "").ToLower();

            int left = 0;
            int right = cleanInput.Length - 1;

            while (left < right)
            {
                if (cleanInput[left] != cleanInput[right])
                    return false;

                left++;
                right--;
            }

            return true;

        }

    }
}
