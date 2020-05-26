using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Proiect_Ip;

namespace UnitTest
{
    class LightCommandTest
    {
        private Light light;
        private LightOffCommand lightOffCommand;
        private LightOnCommand lightOnCommand;

        [SetUp]
        public void Setup()
        {
            light = new Light();
            lightOffCommand = new LightOffCommand(this.light);
            lightOnCommand = new LightOnCommand(this.light);
        }

        [Test]
        public void testLightOnMethodOutput()
        {
            Assert.AreEqual("S-a aprins lumina", light.on());
        }
        [Test]
        public void testLightOffMethodOutput()
        {
            Assert.AreEqual("S-a stins lumina", light.off());
        }
        [Test]
        public void testLightOnCommandOutput()
        {
            Assert.AreEqual("S-a aprins lumina", lightOnCommand.Execute());
        }

        [Test]
        public void testLightOffCommandOutput()
        {
            Assert.AreEqual("S-a stins lumina", lightOffCommand.Execute());
        }

        [Test]
        public void testLightOffCommandIsTheSameAsLightMethod()
        {
            Assert.AreEqual(light.off(), lightOffCommand.Execute());
        }

        [Test]
        public void testLightOnCommandIsTheSameAsLightMethod()
        {
            Assert.AreEqual(light.on(), lightOnCommand.Execute());
        }


    }
}
