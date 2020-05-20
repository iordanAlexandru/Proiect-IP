using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Ip
{
    class StereoOffCommand : Command
	{
		internal Stereo stereo;
		public StereoOffCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}
		public virtual String Execute()
		{
			return stereo.off();
		}
	}
}
