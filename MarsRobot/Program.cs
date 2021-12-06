using MarsRobot.Business.Map;
using MarsRobot.Business.Robot;
using System;

namespace MarsRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validGrid = false;
            var (coordX, coordY) = (0, 0);
            var instructions = "";

            while (validGrid == false)
            {
                Console.WriteLine("Welcome to Mars Robot Controller! Select the size of the Plateau (Format: NUMBERxNUMBER)");
                instructions = Console.ReadLine();
                (coordX, coordY) = GridStringValidator.ReturnValidGridMap(instructions);
                
                if (coordX == 0 || coordY == 0)
                {
                    Console.WriteLine("The grid coordinates are not valid!");
                }
                else
                {
                    validGrid = true;
                }
            }

                Console.WriteLine("Robot instructions:");
                instructions = Console.ReadLine();

                var map = new GridMap(coordX, coordY);
                var robot = new Robot(map);

                var (finalX, finalY, finalDirection) = robot.GetInstructionsAndReturnsFinalLocation(instructions);

                Console.WriteLine($"Final coordinates: X: {finalX}, Y: {finalY} - Direction: {finalDirection}");
                Console.WriteLine(map.PaintMap(finalX, finalY, finalDirection));
            
        }
    }
}
