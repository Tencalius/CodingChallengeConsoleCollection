using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Rover
    {

        //Designs Rover
        public int X { get; private set; } 
        public int Y { get;  private set; }

        public Direction Facing { get; private set; }

        public Rover(int x, int y, Direction facing) 
        {
            X = x;
            Y = y;
            Facing = facing;
        }



        //Rotates Rover 90 degrees counter clockwise
        public void LeftTurn()
        {
            Facing = (Direction)(((int)Facing + 3) % 4);
        }



        //Rotates Rover 90 degrees clockwise
        public void RightTurn() 
        {
            Facing = (Direction)(((int)Facing + 1) % 4);
        }



        //Moves the Rover forwards 1 tile in whichever direction it is facing
        public void ForwardMovement(int maxX, int maxY, bool[,] obstacles)
        {
            int newX = X, newY = Y; 

            switch (Facing)
            {
                case Direction.North:
                    newY = (Y - 1 + maxY) % maxY;
                    break;

                case Direction.East:
                    newX = (X + 1) % maxX;
                    break;

                case Direction.South:
                    newY = (Y + 1) % maxY;
                    break;

                case Direction.West:
                    newX = (X-1) % maxX;
                    break;
            }

            //Ensures the Rover cannot move into tiles occupied by an otbscale, also avoids index outside array when too many inputs
            if (newX >= 0 && newX < maxX && newY >= 0 && newY < maxY)
            {
                if (!obstacles[newY, newX])
                {
                    X = newX;
                    Y = newY;
                }
                else
                {
                    Console.WriteLine("Obstacle encountered");
                }
            }
        }


    }
}
