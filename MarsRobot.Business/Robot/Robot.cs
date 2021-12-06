using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRobot.Business.Map;

namespace MarsRobot.Business.Robot
{
    public class Robot
    {
        private int currentX { get; set; }
        private int currentY { get; set; }
        private Direction currentDirection { get; set; }

        private GridMap gridMap { get; set; }

        public Robot(GridMap gridMap)
        {
            currentX = 1;
            currentY = 1;
            currentDirection = Direction.North;
            this.gridMap = gridMap;
        }

        public (int, int, Direction) GetInstructionsAndReturnsFinalLocation(string instructions)
        {
            foreach (var inst in instructions)
            {
                if (inst != 'F')
                    currentDirection = DirectionChanger.ChangeDirection(currentDirection, inst.ToString());
                else if (inst == 'F')
                    MoveRobot();
            }

            return (currentX, currentY, currentDirection);
        }

        public (int, int, Direction) GetCurrentLocationAndDirection()
        {
            return (currentX, currentY, currentDirection);
        }

        public void MoveRobot()
        {
            var nextX = currentX;
            var nextY = currentY;

            switch (currentDirection)
            {
                case Direction.North:
                    nextX++;
                    break;
                case Direction.South:
                    nextX--;
                    break;
                case Direction.East:
                    nextY++;
                    break;
                case Direction.West:
                    nextY--;
                    break;
            }
            
            if (gridMap.IsLocationValid(nextX, nextY))
            {
                currentX = nextX;
                currentY = nextY;
            }
        }
    }

 

}
