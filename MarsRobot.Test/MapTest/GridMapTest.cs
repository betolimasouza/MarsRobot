using MarsRobot.Business.Map;
using MarsRobot.Business.Robot;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobot.Test.Map
{
    public class GridMapTest
    {
        [Test]
        [TestCase(10, 10, 11, 11, false)]
        [TestCase(10, 10, 10, 10, true)]
        [TestCase(5, 5, 1, 2, true)]
        public void CheckValidLocation(int mapX, int mapY, int newX, int newY, bool result)
        {
            var map = new GridMap(mapX, mapY);
            var isValid = map.IsLocationValid(newX, newY);
            Assert.AreEqual(result, isValid);
        }

        [Test]
        [TestCase(Direction.North, "↑")]
        [TestCase(Direction.East, "→")]
        [TestCase(Direction.South, "↓")]
        [TestCase(Direction.West, "←")]
        public void GetDirectionSymbol(Direction direction, string targetSymbol)
        {
            var map = new GridMap(1, 1);
            var symbol = map.GetDirectionSymbol(direction);

            Assert.AreEqual(targetSymbol, symbol);
        }

        [Test]
        [TestCase(2, 2, 0, 0, Direction.North, "##\n##\n")]
        [TestCase(5, 5, 1, 1, Direction.North, "#####\n#####\n#####\n#####\n↑####\n")]
        public void GetMapPainting(int sizeX, int sizeY, int currX, int currY, Direction currDirection, string targetPainting)
        {
            var map = new GridMap(sizeX, sizeY);
            var painting = map.PaintMap(currX, currY, currDirection);
            Assert.AreEqual(targetPainting, painting);
        }
        
    }
}
