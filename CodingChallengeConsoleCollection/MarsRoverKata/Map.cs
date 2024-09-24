using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    internal class Map
    {
        //Declaration
        private int width;
        private int height;
        //2D array
        private bool[,] obstacle;
        private readonly Rover rover;



        //Constructs map using determined values
        public Map(int width, int height, Rover rover)
        {
            this.width = width;
            this.height = height;
            this.rover = rover;

            obstacle = new bool[width, height];

            GenerateRandomObstacles();

        }



        //private void GenerateRandomObstacles()
        //{
        //    Random rnd = new Random();
        //    int numberOfObstackes = 2;
        //    int x;
        //    int y;

        //    x = rnd.Next(width);
        //    y = rnd.Next(height);
        //    if (obstacle[x, y] || (x == rover.X && y == rover.Y))

        //    {
        //        GenerateRandomObstacles();
        //    }
        //    else
        //    {
        //        obstacle[x, y] = true;
        //    }
        //}


        //Generates random amount and locations for obstacles
        private void GenerateRandomObstacles()
        {
            Random rnd = new Random();

            int x, y, z;
            z = rnd.Next(3, 6); 
            int numberOfObstacles = (width * height) / z;

            for (int i = 0; i < numberOfObstacles; i++)
            {
                do
                {
                    x = rnd.Next(width);
                    y = rnd.Next(height);
                }
                while (obstacle[x, y] || (x == rover.X && y == rover.Y));

                obstacle[x, y] = true;
            }
        }



        //Prints one row at a time based on given factors, is refreshed every movement
        public void PrintMap()
        {
            Console.Clear();

            for (int y = 0; y < height; y++)
            {
                string line = "";

                for (int x = 0; x < width; x++)
                {
                    if (rover.X == x && rover.Y == y)
                    {
                        //Displays Rover as its direction
                        switch (rover.Facing)
                        {
                            case Direction.North:
                                line += "^ ";
                                break;

                            case Direction.East:
                                line += "> ";
                                break;

                            case Direction.South:
                                line += "v ";
                                break;

                            case Direction.West:
                                line += "< ";
                                break;

                        }
                    }

                    //Prints X if obstacle, else prints . as empty space
                    else if (obstacle[y,x])
                    {
                        line += "X ";
                    }
                    else
                    {
                        line += ". ";
                    }
                }
                Console.WriteLine(line);
            }
            Console.WriteLine();
        }



        //Provides access to obstacles, width and height from outside this class
        public bool[,] GetObstacle()
        {
            return obstacle;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        { 
            return height; 
        }

    }
}
