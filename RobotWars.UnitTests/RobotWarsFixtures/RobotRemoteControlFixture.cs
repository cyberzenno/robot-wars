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
    public class RobotRemoteControlFixture
    {
        private Mock<IControllableRobot> robot;
        private RobotRemoteControl robotRemoteControl;

        [TestInitialize]
        public void Setup()
        {
            robot = new Mock<IControllableRobot>();
            robotRemoteControl = new RobotRemoteControl(robot.Object);
        }

        [TestMethod]
        public void SendSingleCommand()
        {
            //Arrange

            //Act
            robotRemoteControl.SendCommands("M");

            //Assert
            robot.Verify(r => r.Move(), Times.Exactly(1));
        }

        [TestMethod]
        public void SendSingleAllCommands()
        {
            //Arrange

            //Act
            robotRemoteControl.SendCommands("M");
            robotRemoteControl.SendCommands("R");
            robotRemoteControl.SendCommands("L");

            //Assert
            robot.Verify(r => r.Move(), Times.Exactly(1));
            robot.Verify(r => r.RotateRight(), Times.Exactly(1));
            robot.Verify(r => r.RotateLeft(), Times.Exactly(1));
        }

        [TestMethod]
        public void SendMultipleCommands()
        {
            //Arrange

            //Act
            robotRemoteControl.SendCommands("MRLmrl");

            //Assert
            robot.Verify(r => r.Move(), Times.Exactly(2));
            robot.Verify(r => r.RotateRight(), Times.Exactly(2));
            robot.Verify(r => r.RotateLeft(), Times.Exactly(2));
        }

    }
}
