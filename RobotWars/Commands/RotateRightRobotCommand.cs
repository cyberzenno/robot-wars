using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public class RotateRightRobotCommand : RotateRobotCommand
    {
        public RotateRightRobotCommand(IOrientableRobot robot)
            : base(robot)
        { }

        public override void Execute()
        {
            RotateRight();
        }

        public override void Undo()
        {
            RotateLeft();
        }
    }
}
