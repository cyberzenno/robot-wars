using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public class RotateLeftRobotCommand : RotateRobotCommand
    {
        public RotateLeftRobotCommand(IOrientableRobot robot)
            : base(robot)
        { }

        public override void Execute()
        {
            RotateLeft();
        }

        public override void Undo()
        {
            RotateRight();
        }
    }
}
