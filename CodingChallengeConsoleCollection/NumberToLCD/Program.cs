using System.Runtime.CompilerServices;

namespace CodingChallengeConsoleCollection.NumberToLCD
{
    public class Program
    {

        private static readonly Dictionary<char, string[]> lcdNumbers = new Dictionary<char, string[]>
        {
            {'0', new[] {" _", "| |", "|_|"} },
            {'1', new[] {" ", " |", " |"} },
            {'2', new[] {"_", "_|", "|_"} },
            {'3', new[] {"_", "_|", "_|"} },
            {'4', new[] {" ", "|_|", "  |"} },
            {'5', new[] {" _", "|_", " _|"} },
            {'6', new[] {" _", "|_", "|_|"} },
            {'7', new[] {"_", " |", " |"} },
            {'8', new[] {" _", "|_|", "|_|"} },
            {'9', new[] {" _", "|_|", " _|"} },
        };



        public static void Run()
        {
            Console.WriteLine("Please enter an integer: \n");
            var input = Console.ReadLine();

            string[] output = {string.Empty, string.Empty, string.Empty};

            foreach (char number in input)
            {
                if (lcdNumbers.TryGetValue(number, out string[] lcdLine))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        output[i] += lcdLine[i] + " ";
                    }
                }
                else
                {
                    Console.WriteLine("Integers only please");
                    return;
                }

            }
            foreach (string line  in output)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }

    }
}
