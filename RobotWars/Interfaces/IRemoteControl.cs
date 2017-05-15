using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Interfaces
{
    public interface IRemoteControl
    {
        void SendCommands(string commands);
    }
}
