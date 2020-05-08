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
		public virtual void Execute()
		{
			stereo.on();
			stereo.setCD();
			stereo.Volume = 11;
		}
	}
}
