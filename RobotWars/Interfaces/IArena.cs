using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotWars.Interfaces
{
    public interface IArena
    {
        int Width { get; }

        int Height { get; }

        void MovementNotified();
    }
}
