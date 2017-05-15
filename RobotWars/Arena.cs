using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public abstract class Arena : IArena
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        private IEnumerable<IArenaRobot> Robots { get; set; }

        public Arena(int width, int height, IEnumerable<IArenaRobot> robots)
        {
            Width = width;
            Height = height;
            Robots = robots;

            foreach (var robot in Robots)
            {
                robot.SetArena(this);
            }
        }

        public void MovementNotified()
        {
            foreach (var robot in Robots)
            {
                if (IsOutOfBoundaries(robot))
                {
                    robot.Penality++;
                    robot.ExecutePenalityAction();
                }
            }
        }

        //Arena rules
        //For simplicity I don't implement further patterns
        private bool IsOutOfBoundaries(IArenaRobot robot)
        {
            var isOutOfWidth = !Enumerable.Range(0, Width).Contains(robot.X);
            var isOutOfHeight = !Enumerable.Range(0, Height).Contains(robot.Y);

            return isOutOfWidth || isOutOfHeight;
        }
    }
}
