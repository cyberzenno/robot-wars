using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public class NoCommand : IRobotCommand
    {
        public void Execute()
        {
            //do nothing
        }

        public void Undo()
        {
            //do nothing
        }
    }
}
