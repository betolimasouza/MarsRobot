using MarsRobot.Business.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;

namespace MarsRobot.Test.RobotTest
{
    public class DirectionChangerTest
    {
        [Test]
        [TestCase(Direction.North, "L", Direction.West)]
        [TestCase(Direction.West, "L", Direction.South)]
        [TestCase(Direction.South, "L", Direction.West)]
        [TestCase(Direction.East, "L", Direction.North)]
        [TestCase(Direction.North, "R", Direction.East)]
        [TestCase(Direction.East, "R", Direction.South)]
        [TestCase(Direction.South, "R", Direction.East)]
        [TestCase(Direction.West, "R", Direction.North)]
        public void TestDirection(Direction currentDirection, string turnDirection, Direction targetDirection)
        {
            var newDirection = DirectionChanger.ChangeDirection(currentDirection, turnDirection);
            Assert.AreEqual(targetDirection, newDirection);
        }
    }
}
