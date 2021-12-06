using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobot.Business.Map
{
    public static class GridStringValidator
    {

        public static (int, int) ReturnValidGridMap(string gridMapString)
        {
            var str = gridMapString.ToLower().Split('x');

            int.TryParse(str[0], out int coordX);
            int.TryParse(str[1], out int coordY);

            return (coordX, coordY);
        }

    }
}
