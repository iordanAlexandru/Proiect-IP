using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Autor: Iordan Alexandru
 * Functionalitate: Mecanism Stereo + functionalitati specifice
 */
namespace Proiect_Ip
{
    class StereoOnWithCDCommand : Command
	{
		internal Stereo stereo;
		public StereoOnWithCDCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}
		public virtual String Execute()
		{
			//aici putem schimba in setDVD / setRadio / etc
            String text = stereo.on() + Environment.NewLine + stereo.setCD() + Environment.NewLine + stereo.setVolume(64);
            return text;
		}
	}
}
