using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotWars.Interfaces
{
    public interface IControllableRobot : IOrientableRobot
    {
        void Move();

        void RotateLeft();

        void RotateRight();
    }
}
