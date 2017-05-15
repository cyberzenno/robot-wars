using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.UnitTests
{
    [TestClass]
    public class MoveRobotCommandFixture
    {
        private Mock<IOrientableRobot> robot;
        private MoveRobotCommand moveCommand;

        [TestInitialize]
        public void Setup()
        {
            robot = new Mock<IOrientableRobot>();
            robot.SetupAllProperties();
            robot.Object.X = 0;
            robot.Object.Y = 0;

            moveCommand = new MoveRobotCommand(robot.Object);
        }

        [TestMethod]
        public void MoveToN()
        {
            //Arrange
            robot.Object.Orientation = RobotOrientation.N;

            //Act
            moveCommand.Execute();

            //Assert
            robot.VerifySet(x => x.X = 0);
            robot.VerifySet(x => x.Y = 1);
        }

        [TestMethod]
        public void MoveToE()
        {
            //Arrange
            robot.Object.Orientation = RobotOrientation.E;

            //Act
            moveCommand.Execute();

            //Assert
            robot.VerifySet(x => x.X = 1);
            robot.VerifySet(x => x.Y = 0);
        }

        [TestMethod]
        public void MoveToS()
        {
            //Arrange
            robot.Object.Orientation = RobotOrientation.S;

            //Act
            moveCommand.Execute();

            //Assert
            robot.VerifySet(x => x.X = 0);
            robot.VerifySet(x => x.Y = -1);
        }

        [TestMethod]
        public void MoveToW()
        {
            //Arrange
            robot.Object.Orientation = RobotOrientation.W;

            //Act
            moveCommand.Execute();

            //Assert
            robot.VerifySet(x => x.X = -1);
            robot.VerifySet(x => x.Y = 0);
        }
    }
}
