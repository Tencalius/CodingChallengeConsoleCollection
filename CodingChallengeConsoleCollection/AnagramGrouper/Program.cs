using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeConsoleCollection.AnagramGrouper
{
    public class Program
    {

        public static List<List<string>> AnagramGroups(List<string> groups)
        {
            return groups
                .GroupBy(word => String.Concat(word.OrderBy(c => c)))
                .Select(groups => groups.ToList())
                .ToList();
        }



        public static void Run()
        {

            Console.WriteLine("Welcome to your Anagram Grouping application! \n" +
                "\n" +
                "Enter words you'd like to analyse the contents of, then enter \"0\" to analyse them or just exit the program");

            var wordList = new List<string>();
            string? input = null;

            do
            {
                input = Console.ReadLine();
                
                if (input != "0")
                {
                    wordList.Add(input);
                }


            } while (input != "0");

            var result = AnagramGroups(wordList);

            Console.WriteLine("Your resulting groups are:");
            foreach (var group in result)
            {
                Console.WriteLine($"[{string.Join(", ", group)}]");
            }


        }





    }
}
