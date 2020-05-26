using System;
using System.Collections.Generic;
using System.Text;
using Proiect_Ip;
using NUnit.Framework;

namespace UnitTest
{
    class GarageDoorCommandTest
    {
        private GarageDoor garageDoor;
        private GarageDoorDownCommand garageDoorDownCommand;
        private GarageDoorUpCommand garageDoorUpCommand;
        private const string GARAGE_DOOR_DOWN_OUTPUT = "S-a coborat usa garajului";
        private const string GARAGE_DOOR_STOP_OUTPUT = "S-a oprit usa garajului";
        private const string GARAGE_DOOR_UP_OUTPUT = "S-a ridicat usa garajului";


        [SetUp]
        public void Setup()
        {
            garageDoor = new GarageDoor();
            garageDoorDownCommand = new GarageDoorDownCommand(this.garageDoor);
            garageDoorUpCommand = new GarageDoorUpCommand(this.garageDoor);
        }

        [Test]
        public void testGarageDoorUpMethodOutput()
        {
            Assert.AreEqual(GARAGE_DOOR_UP_OUTPUT, garageDoor.up());
        }
        [Test]
        public void testGarageDoorDownMethodOutput()
        {
            Assert.AreEqual(GARAGE_DOOR_DOWN_OUTPUT, garageDoor.down());
        }
        [Test]
        public void testGarageDoorUpCommandOutput()
        {
            Assert.AreEqual(GARAGE_DOOR_UP_OUTPUT, garageDoorUpCommand.Execute());
        }

        [Test]
        public void testGarageDoorStopMethodOutput()
        {
            Assert.AreEqual(GARAGE_DOOR_STOP_OUTPUT, garageDoor.stop());
        }
        [Test]
        public void testGarageDoorDownCommandOutput()
        {
            Assert.AreEqual(GARAGE_DOOR_DOWN_OUTPUT, garageDoorDownCommand.Execute());
        }

        [Test]
        public void testGarageDoorDownCommandIsTheSameAsGarageDoorMethod()
        {
            Assert.AreEqual(garageDoor.down(), garageDoorDownCommand.Execute());
        }

        [Test]
        public void testGarageDoorUpCommandIsTheSameAsGarageDoorMethod()
        {
            Assert.AreEqual(garageDoor.up(), garageDoorUpCommand.Execute());
        }

    }
}
