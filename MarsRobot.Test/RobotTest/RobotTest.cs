using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRobot.Business.Robot;
using MarsRobot.Business.Map;

namespace MarsRobot.Test.RobotTest
{
    public class RobotTest
    {
        private GridMap gridMap;
        private  Robot robot;

        [SetUp]
        public void SetUp()
        {
            gridMap = new GridMap(10, 10);
            robot = new Robot(gridMap);
        }

        [Test]
        [TestCase("FFRFLFLF", 4, 1, Direction.West)]
        public void GetFinalLocation(string instructions, int targetX, int targetY, Direction targetDirection)
        {
            var (finalX, finalY, direction) = robot.GetInstructionsAndReturnsFinalLocation(instructions);

            Assert.AreEqual(targetX, finalX);
            Assert.AreEqual(targetY, finalY);
            Assert.AreEqual(targetDirection, direction);
        }

        [Test]
        public void MoveRobotTest()
        {
            robot.MoveRobot();
            var (currX, currY, currDirection) = robot.GetCurrentLocationAndDirection();

            Assert.AreEqual(2, currX);
            Assert.AreEqual(1, currY);
            Assert.AreEqual(Direction.North, currDirection);
        }

    }
}
