using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public class SingleRobotArena5x5 : Arena
    {
        public SingleRobotArena5x5(IArenaRobot robot)
            : base(5, 5, new List<IArenaRobot>() { robot })
        { }
    }
}
