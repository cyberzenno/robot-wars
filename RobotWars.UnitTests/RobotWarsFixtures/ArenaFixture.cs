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
    public class ArenaFixture
    {
        private Mock<IArenaRobot> robot;
        private IArena arena;

        [TestInitialize]
        public void Setup()
        {
            robot = new Mock<IArenaRobot>();
            robot.SetupAllProperties();
            robot.Object.Penality = 0;

            arena = new SingleRobotArena5x5(robot.Object);
        }

        [TestMethod]
        public void NotOutOfBoundaries()
        {
            //Arrange
            robot.Setup(r => r.X).Returns(1);
            robot.Setup(r => r.Y).Returns(1);

            //Act
            arena.MovementNotified();

            //Assert
            robot.VerifySet(r => r.Penality = 0);
        }

        [TestMethod]
        public void OutOfBoundaryX()
        {
            //Arrange
            robot.Setup(r => r.X).Returns(10);
            robot.Setup(r => r.Y).Returns(1);

            //Act
            arena.MovementNotified();

            //Assert
            robot.VerifySet(r => r.Penality = 1);
        }

        [TestMethod]
        public void OutOfBoundaryY()
        {
            //Arrange
            robot.Setup(r => r.X).Returns(1);
            robot.Setup(r => r.Y).Returns(10);

            //Act
            arena.MovementNotified();

            //Assert
            robot.VerifySet(r => r.Penality = 1);
        }

        [TestMethod]
        public void OutOfBoundaries()
        {
            //Arrange
            robot.Setup(r => r.X).Returns(10);
            robot.Setup(r => r.Y).Returns(10);

            //Act
            arena.MovementNotified();

            //Assert
            robot.VerifySet(r => r.Penality = 1);
        }
    }
}
