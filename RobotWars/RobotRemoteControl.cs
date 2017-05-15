using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public class RobotRemoteControl : IRemoteControl
    {
        private IControllableRobot robot;

        public RobotRemoteControl(IControllableRobot robot)
        {
            this.robot = robot;
        }

        public void SendCommands(string commands)
        {
            foreach (var command in commands.ToLower())
            {
                switch (command)
                {
                    case 'm':
                        robot.Move();
                        break;

                    case 'l':
                        robot.RotateLeft();
                        break;
                    case 'r':
                        robot.RotateRight();
                        break;

                    default:
                        throw new NotSupportedException();
                }
            }
        }

    }
}
