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
    public class RobotFixture
    {
        private Robot robot;
        private Mock<IArena> arena;

        [TestInitialize]
        public void Setup()
        {
            robot = new Robot(0, 0, RobotOrientation.N);
            arena = new Mock<IArena>();

            robot.SetArena(arena.Object);
        }

        [TestMethod]
        public void NotifyNoMovement()
        {
            //Arrange

            //Act
            robot.RotateLeft();
            robot.RotateLeft();

            //Assert
            arena.Verify(a => a.MovementNotified(), Times.Never);
        }

        [TestMethod]
        public void NotifyMovement()
        {
            //Arrange

            //Act
            robot.Move();

            //Assert
            arena.Verify(a => a.MovementNotified(), Times.Once);
        }

        [TestMethod]
        public void ExecutePenalityActionForMovement()
        {
            //Arrange

            //Act
            robot.Move();
            robot.ExecutePenalityAction();

            //Assert
            Assert.IsTrue(robot.Y == 0);
        }

        [TestMethod]
        public void ExecuteNoPenalityActionForRotateRight()
        {
            //Arrange

            //Act
            robot.RotateRight();
            robot.ExecutePenalityAction();

            //Assert
            Assert.IsTrue(robot.Orientation == RobotOrientation.E);
        }

        [TestMethod]
        public void ExecuteNoPenalityActionForRotateLeft()
        {
            //Arrange

            //Act
            robot.RotateLeft();
            robot.ExecutePenalityAction();

            //Assert
            Assert.IsTrue(robot.Orientation == RobotOrientation.W);
        }
    }
}
