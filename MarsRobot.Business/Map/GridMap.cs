using MarsRobot.Business.Robot;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobot.Business.Map
{
    public class GridMap
    {
        private int[,] FullGrid { get; set; }

  
        public GridMap(int sizeX, int sizeY)
        {
            FullGrid = new int[sizeX,sizeY];
        }

        public bool IsLocationValid(int coordX, int coordY)
        {
            if (coordX <= FullGrid.GetLength(0) && coordY <= FullGrid.GetLength(1))
                return true;

            return false;
        }

        public string PaintMap(int currentX, int currentY, Direction direction)
        {
            var map = "";

            for (int i = FullGrid.GetLength(0); i > 0 ; i--)
            {
                for (int j = 1; j <= FullGrid.GetLength(1); j++)
                {
                    if ((i, j) == (currentX, currentY))
                        map += GetDirectionSymbol(direction);
                    else
                        map += "#";
                }

                map += "\n";
            }

            return map;
        }

        public string GetDirectionSymbol(Direction direction)
        {
            var symbol = "#";

            switch (direction)
            {
                case Direction.North:
                    symbol = "↑";
                    break;
                case Direction.South:
                    symbol = "↓";
                    break;
                case Direction.East:
                    symbol = "→";
                    break;
                case Direction.West:
                    symbol = "←";
                    break;
            }

            return symbol;
        }


    }
}
