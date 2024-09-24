using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BowlingKataApp
{
    internal class Utilities
    {

        public static int GetScoreInput(string currentFramePrompt)
        {

                    Console.WriteLine(currentFramePrompt);
                    string scoreInput = Console.ReadLine();

                    return int.Parse(scoreInput);


                }
            


        //Receives our score input and adds it to the scores array
        public static int ManageFrameAndScore(int[] allScores, int scoreIndex, int frame)
        {
            var firstThrow = GetScoreInput($"You are on frame {frame} \n Please input your first score:");


                //If strike and not final frame, updates index and counter then skips to next turn
            if (frame < 10 && firstThrow == 10)
            {
                allScores[scoreIndex] = 10;

                return scoreIndex + 1;
            }


                //If not strike, updates index and counter then moves to second score
            allScores[scoreIndex] = firstThrow;

            if (frame < 10 || (frame == 10 && firstThrow != 10) )
            {
                var secondThrow = GetScoreInput("Please input your second score: ");
                allScores[scoreIndex + 1] = secondThrow;

                return scoreIndex + 2;
            }

            return scoreIndex + 1;

        }



        //Manages rolls/final frame
        public static int ManageFinalFrame(int[] allScores, int scoreIndex)
        {
            //if (allScores[scoreIndex - 2] == 10 || (allScores[scoreIndex - 2] + allScores[scoreIndex - 1] >= 10))
            //{
            //    int bonusThrow = GetScoreInput("Enter your extra score!: ");

            //    allScores[scoreIndex] = bonusThrow;

            //    return scoreIndex + 1;
            //}

            //return scoreIndex;

            if (allScores[scoreIndex - 2] == 10)
            {
                var bonusThrowOne = GetScoreInput("Enter your first bonus score!: ");
                allScores[scoreIndex] = bonusThrowOne;

                var bonusThrowTwo = GetScoreInput("Enter your second bonus score!: ");
                allScores[scoreIndex + 1] = bonusThrowTwo;

                return scoreIndex + 2;

            }
            else if (allScores[scoreIndex - 2] + allScores[scoreIndex - 1] >= 10)
            {
                var bonusThrowOne = GetScoreInput("Enter your extra score!: ");
                allScores[scoreIndex] = bonusThrowOne;
                return scoreIndex + 1;
            }
            else
            {
                return scoreIndex;
            }

        }





        //Takes scores array and calculates final score
        public static int CalculateFinalScore(int[] allScores)
        {

            var finalScore = 0;
            var scoreIndex = 0;

            //Tally scores
            for (int frame = 1; frame <= 10; frame++)
            {


                if (allScores[scoreIndex] == 10) //Strike clause
                {
                    finalScore = finalScore + 10 + allScores[scoreIndex + 1] + allScores[scoreIndex + 2];
                    scoreIndex++;
                }

                else if (allScores[scoreIndex] + allScores[scoreIndex + 1] == 10) //Spare clause
                {
                    finalScore = finalScore + (10 + allScores[scoreIndex + 1]);
                    scoreIndex = scoreIndex + 2;
                }
                else
                {
                    finalScore = finalScore + (allScores[scoreIndex] + (allScores[scoreIndex + 1]));
                    scoreIndex = scoreIndex + 2;

                    
                }

            }

            return finalScore;

        }
    }
}


//Try catch block testing, outside of scope

//        public static int GetScoreInput(string currentFramePrompt)
//{
//    int scoreInputFinal;

//    while (true)
//    {
//        try
//        {
//            Console.WriteLine(currentFramePrompt);
//            string scoreInput = Console.ReadLine();

//            if (string.IsNullOrEmpty(scoreInput))
//            {
//                throw new Exception("Input cnanot be empty, please enter a number");
//            }

//            scoreInputFinal = int.Parse(scoreInput);
//            break;
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("Input cannot be empty, please enter a number");
//        }
//    }

//    string value = int.Parse(scoreInputFinal);
//}
//        }






//DEMO CREATING EMPLOYEE CLASS