using RobotWars;
using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public class Robot : IRobot
    {
        private IRobotCommand moveCommand;
        private IRobotCommand rotateLeftCommand;
        private IRobotCommand rotateRightCommand;
        private IRobotCommand lastMoveCommand;
        private IArena arena;

        //Properties
        public int X { get; set; }
        public int Y { get; set; }
        public RobotOrientation Orientation { get; set; }

        public int Penality { get; set; }

        //Constructor
        public Robot(int x, int y, RobotOrientation orientation)
        {
            X = x;
            Y = y;
            Orientation = orientation;
            Penality = 0;

            moveCommand = new MoveRobotCommand(this);
            rotateLeftCommand = new RotateLeftRobotCommand(this);
            rotateRightCommand = new RotateRightRobotCommand(this);
            lastMoveCommand = new NoCommand();
        }


        public void Move()
        {
            moveCommand.Execute();
            lastMoveCommand = moveCommand;

            NotifyMovement();
        }

        public void RotateLeft()
        {
            rotateLeftCommand.Execute();
        }

        public void RotateRight()
        {
            rotateRightCommand.Execute();
        }


        public void SetArena(IArena arena)
        {
            this.arena = arena;
        }

        public void NotifyMovement()
        {
            if (arena != null)
            {
                arena.MovementNotified();
            }
        }

        public void ExecutePenalityAction()
        {
            lastMoveCommand.Undo();
        }


        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public RobotOrientation GetOrientation()
        {
            return Orientation;
        }
    }
}
