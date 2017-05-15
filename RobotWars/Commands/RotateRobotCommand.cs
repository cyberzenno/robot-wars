using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public abstract class RotateRobotCommand : RobotCommand
    {
        public RotateRobotCommand(IOrientableRobot robot)
            : base(robot)
        { }

        internal void RotateLeft()
        {
            if (robot.Orientation == RobotOrientation.N)
            {
                robot.Orientation = RobotOrientation.W;
            }
            else
            {
                robot.Orientation--;
            }
        }

        internal void RotateRight()
        {
            if (robot.Orientation == RobotOrientation.W)
            {
                robot.Orientation = RobotOrientation.N;
            }
            else
            {
                robot.Orientation++;
            }
        }
    }
}
