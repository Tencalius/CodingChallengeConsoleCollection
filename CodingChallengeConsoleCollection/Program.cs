using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using BowlingKataApp;

namespace CodingChallengeConsoleCollection
{
    static class Program
    {
        public static void Main()
        {
            //Intro
            Console.WriteLine("\n" +
                "This is a collection of the console app C# coding challenges I have completed so far!\n" +
                "\n" +
                "Please select an app:");

            AppSelection();



            //Select an app
            static void AppSelection()
            {
                Console.WriteLine("\n" +
                    "1 - Bowling Kata\n" +
                    "2 - Sum of numbers to one number\n" +
                    "3 - Mars Rover Kata\n" +
                    "4 - Vowels and Consonants\n" +
                    "5 - Reverse a string\n" +
                    "6 - Factorial calculator\n" +
                    "7 - Anagram grouper");


                string userInput = Console.ReadLine();
                Console.WriteLine();

                switch (userInput)
                {
                    case "1":
                        BowlingKataApp.Program.Run();
                        break;
                    case "2":
                        SumOfNumbers.Program.Run();
                        break;
                    case "3":
                        MarsRoverKata.Program.Run();
                        break;
                    case "4":
                        VowelsAndConsonants.Program.Run();
                        break;
                    case "5":
                        ReverseAString.Program.Run();
                        break;
                    case "6":
                        FactorialCalculator.Program.Run();
                        break;
                    case "7":
                        AnagramGrouper.Program.Run();
                        break;
                    default:
                        Console.Clear();
                        Main();
                        break;
                }
            }



        }
    }
}