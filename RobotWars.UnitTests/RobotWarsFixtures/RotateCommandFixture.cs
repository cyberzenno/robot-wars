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
    public class RotateCommandFixture
    {
        private Mock<IOrientableRobot> robot;
        private RotateRightRobotCommand rotateRightCommand;
        private RotateLeftRobotCommand rotateLeftCommand;

        [TestInitialize]
        public void Setup()
        {
            robot = new Mock<IOrientableRobot>();
            robot.SetupAllProperties();
            robot.Object.Orientation = RobotOrientation.N;


            rotateRightCommand = new RotateRightRobotCommand(robot.Object);
            rotateLeftCommand = new RotateLeftRobotCommand(robot.Object);
        }

        [TestMethod]
        public void RotateRight90()
        {
            //Arrange

            //Act
            rotateRightCommand.Execute();

            //Assert
            robot.VerifySet(x => x.Orientation = RobotOrientation.E);
        }

        [TestMethod]
        public void RotateRight180()
        {
            //Arrange

            //Act
            rotateRightCommand.Execute();
            rotateRightCommand.Execute();

            //Assert
            robot.VerifySet(x => x.Orientation = RobotOrientation.S);
        }

        [TestMethod]
        public void RotateRight270()
        {
            //Arrange

            //Act
            rotateRightCommand.Execute();
            rotateRightCommand.Execute();
            rotateRightCommand.Execute();

            //Assert
            robot.VerifySet(x => x.Orientation = RobotOrientation.W);
        }

        [TestMethod]
        public void RotateRight360()
        {
            //Arrange

            //Act
            rotateRightCommand.Execute();
            rotateRightCommand.Execute();
            rotateRightCommand.Execute();
            rotateRightCommand.Execute();

            //Assert
            robot.VerifySet(x => x.Orientation = RobotOrientation.N);
        }

        [TestMethod]
        public void RotateLeft90()
        {
            //Arrange

            //Act
            rotateLeftCommand.Execute();

            //Assert
            robot.VerifySet(x => x.Orientation = RobotOrientation.W);
        }

        [TestMethod]
        public void RotateLeft180()
        {
            //Arrange

            //Act
            rotateLeftCommand.Execute();
            rotateLeftCommand.Execute();

            //Assert
            robot.VerifySet(x => x.Orientation = RobotOrientation.S);
        }

        [TestMethod]
        public void RotateLeft270()
        {
            //Arrange

            //Act
            rotateLeftCommand.Execute();
            rotateLeftCommand.Execute();
            rotateLeftCommand.Execute();

            //Assert
            robot.VerifySet(x => x.Orientation = RobotOrientation.E);
        }

        [TestMethod]
        public void RotateLeft360()
        {
            //Arrange

            //Act
            rotateLeftCommand.Execute();
            rotateLeftCommand.Execute();
            rotateLeftCommand.Execute();
            rotateLeftCommand.Execute();

            //Assert
            robot.VerifySet(x => x.Orientation = RobotOrientation.N);
        }

    }
}
