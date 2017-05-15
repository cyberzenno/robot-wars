using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public abstract class RobotCommand : IRobotCommand
    {
        protected IOrientableRobot robot;

        public RobotCommand(IOrientableRobot robot)
        {
            this.robot = robot;
        }

        public abstract void Execute();

        public abstract void Undo();
    }
}
