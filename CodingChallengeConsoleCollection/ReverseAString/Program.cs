using System.Text;

namespace ReverseAString
{
    static class Program
    {
        //Setup, takes info and passes it to reverse method, returns the value and prints it
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the string you would like reversed:");

            string userInput = Console.ReadLine();

            StringBuilder str = new StringBuilder(userInput);

            ReverseString(str);

            Console.WriteLine(str);


            Console.WriteLine("Hit Enter to return to the main menu");
            Console.ReadLine();
        }



        
        public static void ReverseString(StringBuilder str)
        {
            int strLength = str.Length;

            for (int i = 0; i < strLength / 2; i++)
            {
                char tempChar = str[i];
                str[i] = str[strLength - i - 1];
                str[strLength - i - 1] = tempChar;

            }
        }
    }
}