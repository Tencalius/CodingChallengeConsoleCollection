
//To do:
//Implement try catch block for empty input  -
//Methods ✓
//+= ✓
//Make it work, do tomorrow, only thing left is 3rd bonus roll ✓
//Implement var, make more readable ✓ 



namespace BowlingKataApp
{

    static class Program
    {
        public static void Run()
        {
            //Intro
            Console.WriteLine("Welcome to your bowling score application! \n All you have to do is input the amount of pins you knocked down for each respective attempt.");


            //Variable declaration
            int[] allScores = new int[21];
            var scoreIndex = 0;
            var finalScore = 0;


            //Frame loop
            for (var frame = 1; frame <= 10; frame++)
            {
                //Console.WriteLine($"\n You are on frame {frame} \n Please input your score:");

                scoreIndex = Utilities.ManageFrameAndScore(allScores, scoreIndex, frame);

                if (frame == 10)
                {
                    scoreIndex = Utilities.ManageFinalFrame(allScores, scoreIndex);

                }

            }


            //Tallies scores
            finalScore = Utilities.CalculateFinalScore(allScores);

            Console.WriteLine($"Your final score was  {finalScore}");
            Console.WriteLine("Press Enter to return to the main menu");
            Console.ReadLine();
        }
    }


}






////Extra light version
//int[] allScores = new int[21] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 };
//int scoreIndex = 0;
//string scoreInput;
//int finalScore = 0;




////Tallies scores
//for (int frame = 1; frame <= 10; frame++)
//{
//    if (allScores[scoreIndex] == 10) //Strike clause
//    {
//        finalScore += 10 + allScores[scoreIndex + 1] + allScores[scoreIndex + 2];
//        scoreIndex++;
//    }

//    else if (allScores[scoreIndex] + allScores[scoreIndex + 1] == 10) //Spare clause
//    {
//        finalScore += 10 + allScores[scoreIndex + 1];
//        scoreIndex += 2;
//    }
//    else
//    {
//        finalScore += allScores[scoreIndex] + (allScores[scoreIndex + 1]);
//        scoreIndex += 2;
//    }
//}

//Console.WriteLine("Your final score was " + finalScore);
