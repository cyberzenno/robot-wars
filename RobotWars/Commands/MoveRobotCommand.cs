using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public class MoveRobotCommand : RobotCommand
    {
        public MoveRobotCommand(IOrientableRobot robot)
            : base(robot)
        { }

        public override void Execute()
        {
            move(1);
        }

        public override void Undo()
        {
            move(-1);
        }

        private void move(int increment)
        {
            switch (robot.Orientation)
            {
                case RobotOrientation.N:
                    robot.Y += increment;
                    break;
                case RobotOrientation.E:
                    robot.X += increment;
                    break;
                case RobotOrientation.S:
                    robot.Y -= increment;
                    break;
                case RobotOrientation.W:
                    robot.X -= increment;
                    break;
                default:
                    break;
            }
        }
    }
}
