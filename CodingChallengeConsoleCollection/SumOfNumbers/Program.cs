namespace SumOfNumbers
{
    class Program
    {
        public static void Run()
        {

            //Setup for UI
            Console.WriteLine("Enter your number");
            string userInput = Console.ReadLine();


            //Validates user input as an integer 
            if (int.TryParse(userInput, out int outputValue))
            {
                //Loop to repeatedly sum values until less than 10
                while (outputValue > 9)
                {
                    outputValue = outputValue.ToString().Sum(x => x - '0');
                }   //Character - 0 uses arithmetic on Ascii values to find true value



                Console.WriteLine($"Result was: {outputValue}\n");
                Console.WriteLine("Hit Enter to return to the main menu");
                Console.ReadLine();

            }

            else //Kicks back to top if invalid input
            {
                Console.WriteLine("Please enter a valid number!\n");
                Run();


            }
        }
    }

}