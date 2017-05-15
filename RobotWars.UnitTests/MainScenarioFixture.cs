using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Interfaces;
using System.Collections.Generic;
using RobotWars;

namespace RobotWars.UnitTests
{
    [TestClass]
    public class MainScenarioFixture
    {
        private const RobotOrientation N = RobotOrientation.N;
        private const RobotOrientation E = RobotOrientation.E;
        private const RobotOrientation S = RobotOrientation.S;
        private const RobotOrientation W = RobotOrientation.W;

        private IArena arena;
        private IRemoteControl remoteControl;
        private IRobot robot;

        [TestMethod]
        public void Scenario1()
        {
            //Scenario 1: 0, 2, E MLMRMMMRMMRR Position: 4, 1, N - Penalties: 0
            //Arrange
            ArrangeScenario(0, 2, E);

            //Act
            remoteControl.SendCommands("MLMRMMMRMMRR");

            //Assert
            AssertScenario(4, 1, N, 0);
        }

        [TestMethod]
        public void Scenario2()
        {
            //Scenario 2: 4, 4, S LMLLMMLMMMRMM Position: 0, 1, W - Penalties: 1
            //Arrange
            ArrangeScenario(4, 4, S);

            //Act
            remoteControl.SendCommands("LMLLMMLMMMRMM");

            //Assert
            AssertScenario(0, 1, W, 1);
        }

        [TestMethod]
        public void Scenario3()
        {
            //Scenario 3: 2, 2, W MLMLMLMRMRMRMRM Position: 2, 2, N - Penalties: 0

            //Arrange
            ArrangeScenario(2, 2, W);

            //Act
            remoteControl.SendCommands("MLMLMLMRMRMRMRM");

            //Assert
            AssertScenario(2, 2, N, 0);
        }

        [TestMethod]
        public void Scenario4()
        {
            //Scenario 4: 1, 3, N MMLMMLMMMMM Position: 0, 0, S - Penalties: 3

            //Arrange
            ArrangeScenario(1, 3, N);

            //Act
            remoteControl.SendCommands("MMLMMLMMMMM");

            //Assert
            AssertScenario(0, 0, S, 3);
        }


        private void ArrangeScenario(int initialX, int initialY, RobotOrientation initialOrientation)
        {
            robot = new Robot(initialX, initialY, initialOrientation);
            arena = new SingleRobotArena5x5(robot);
            remoteControl = new RobotRemoteControl(robot);
        }

        private void AssertScenario(int expX, int expY, RobotOrientation expOrientation, int expPenalities)
        {
            Assert.IsTrue(robot.X == expX);
            Assert.IsTrue(robot.Y == expY);
            Assert.IsTrue(robot.Orientation == expOrientation);
            Assert.IsTrue(robot.Penality == expPenalities);
        }
    }
}
