using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeConsoleCollection.FactorialCalculator
{
    public class Program
    {
        public static void Run()
        {
            Console.WriteLine("Which number would you like thw factorial of?");

            int n = int.Parse(Console.ReadLine());

            var result = Factorial(n);

            Console.WriteLine($"The factorial of {n} is {result}");

            Console.WriteLine("Hit Enter to return to the main menu");
            Console.ReadLine();

        }



        private static Dictionary<int, long> memoisation = new Dictionary<int, long>();
            


        private static long Factorial(int n)
        {
            if (n == 0 || n == 1)  return 1;


            if (memoisation.ContainsKey(n)) return memoisation[n];

            memoisation[n] = n * Factorial(n-1);

            return memoisation[n];

        }


    }
}
