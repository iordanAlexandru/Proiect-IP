using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            stereo.Volume = 11;

            String text = stereo.on() + Environment.NewLine + stereo.setCD();
            return text;
		}
	}
}
