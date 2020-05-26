using System;
using System.Collections.Generic;
using System.Text;
using Proiect_Ip;
using NUnit.Framework;

namespace UnitTest
{
    class StereoCommandTest
    {
        private Stereo stereo;
        private StereoOffCommand stereoOffCommand;
        private StereoOnWithCDCommand stereoOnCommand;
        private const string STEREO_ON_OUTPUT = "Boxele sunt pornite";
        private const string STERE_OFF_OUTPUT = "Boxele sunt oprite";
        private const string CD_OUTPUT = "L-am bagat pe Hrușcă la CD";
        private const string DVD_OUTPUT = "Boxele citesc fisiere media de pe   DVD";
        private const string RADIO_OUTPUT = "Boxele sunt conectate la Radio";
        private const string VOLUME_OUTPUT = "Volumul boxelor este setat la ";


        [SetUp]
        public void Setup()
        {
            stereo = new Stereo();
            stereoOffCommand = new StereoOffCommand(this.stereo);
            stereoOnCommand = new StereoOnWithCDCommand(this.stereo);
        }

        [Test]
        public void testStereoOnMethodOutput()
        {
            Assert.AreEqual(STEREO_ON_OUTPUT, stereo.on());
        }
        [Test]
        public void testStereoOffMethodOutput()
        {
            Assert.AreEqual(STERE_OFF_OUTPUT, stereo.off());
        }
        [Test]
        public void testStereoOnWithCDCommandOutput()
        {
            Assert.AreEqual(STEREO_ON_OUTPUT + "\r\n" + CD_OUTPUT + "\r\n" + VOLUME_OUTPUT + "64", stereoOnCommand.Execute());
        }


        [Test]
        public void testStereoOffCommandOutput()
        {
            Assert.AreEqual(STERE_OFF_OUTPUT, stereoOffCommand.Execute());
        }

        [Test]
        public void testStereoOffCommandIsTheSameAsStereoMethod()
        {
            Assert.AreEqual(stereo.off(), stereoOffCommand.Execute());
        }

        [Test]
        public void testStereoOnCommandIsTheDifferentThanStereoWithCDMethod()
        {
            Assert.AreNotEqual(stereo.on(), stereoOnCommand.Execute());
        }

        [Test]
        public void testStereoSetVolumeMethod()
        {
            int volume = 100;
            Assert.AreEqual(VOLUME_OUTPUT + volume, stereo.setVolume(volume));
        }
        [Test]
        public void testStereoSetCDMethod()
        {
            Assert.AreEqual(CD_OUTPUT, stereo.setCD());
        }
        [Test]
        public void testStereoSetDVDMethod()
        {
            Assert.AreEqual(DVD_OUTPUT, stereo.setDVD());
        }
        [Test]
        public void testStereoSetRadioMethod()
        {
            Assert.AreEqual(RADIO_OUTPUT, stereo.setRadio());
        }

    }
}
