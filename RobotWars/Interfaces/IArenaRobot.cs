using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotWars.Interfaces
{
    public interface IArenaRobot : IOrientableRobot
    {
        int Penality { get; set; }

        void SetArena(IArena arena);

        void NotifyMovement();

        void ExecutePenalityAction();
    }
}
