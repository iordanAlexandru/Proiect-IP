﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Ip
{
    class LightOffCommand : Command
    {
		internal Light light;
		public LightOffCommand(Light light)
		{
			this.light = light;
		}
		public virtual void Execute()
		{
			light.off();
		}
	}
}
