
namespace MarsRoverKata
{
    class Program
    {
        public static void Run()
        {
            //Declaration, hard coded values for map dimensions and starting position
            int mapWidth = 8;
            int mapHeight = 8;
            Rover rover = new Rover(0, 0, Direction.South);
            Map map = new Map(mapWidth, mapHeight, rover);



            //No exit condition, prints map and takes input over and over until program hard close
            while (true)
            {
                map.PrintMap();

                Console.WriteLine("Enter L for left turn, R for right turn, F for forward");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                if (userInput.Length > 0)
                {
                    char input = char.ToUpper(userInput[0]);

                    switch (char.ToUpper(input))
                    {
                        case 'L':
                            rover.LeftTurn();
                            break;

                        case 'R':
                            rover.RightTurn();
                            break;

                        case 'F':
                            rover.ForwardMovement(map.GetWidth(), map.GetHeight(), map.GetObstacle());
                            break;
                        default:
                            Console.WriteLine("Invalid command");
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid command, try again");
                }
            }
        }
    }
}