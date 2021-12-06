using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobot.Business.Robot
{
    public static class DirectionChanger
    {
        public static Direction ChangeDirection(Direction currentDirection, string turnDirection)
        {
            switch (currentDirection)
            {
                case Direction.North:
                    if (turnDirection == "L") return Direction.West;
                    else if (turnDirection == "R") return Direction.East;
                    break;
                case Direction.East:
                    if (turnDirection == "L") return Direction.North;
                    else if (turnDirection == "R") return Direction.South;
                    break;
                case Direction.South:
                    if (turnDirection == "L") return Direction.West;
                    else if (turnDirection == "R") return Direction.East;
                    break;
                case Direction.West:
                    if (turnDirection == "L") return Direction.South;
                    else if (turnDirection == "R") return Direction.North;
                    break;
            }

            return Direction.Invalid;
        }
    }
}
