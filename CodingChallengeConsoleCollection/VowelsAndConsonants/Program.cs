
using System.Security;

namespace VowelsAndConsonants
{
    static class Program
    {
        //Setup, takes info and passes it to count method, then uses count to print the final tally
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the string you would like to count the vowels and consonants in:");

            string input = Console.ReadLine();

            var finalScore = CountVowelsAndConsonantsMethod(input);
            Console.WriteLine($"Vowels: {finalScore.vowels} \nConsonants: {finalScore.consonants}");

            Console.WriteLine("Hit Enter to return to the main menu");
            Console.ReadLine();
            
        }



        //For each character in string, checks if it's a letter and if it's a vowel, if both increments vowel, if just letter increments consonants
        static (int vowels, int consonants) CountVowelsAndConsonantsMethod(string input)
        {
            int vowels = 0;
            int consonants = 0;

            string lowerCaseInput = input.ToLower();

            foreach (char c in lowerCaseInput)
            {
                if (char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }
            return (vowels, consonants);
        }
    }
}