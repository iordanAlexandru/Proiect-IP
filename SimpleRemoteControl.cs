using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Ip
{
    class SimpleRemoteControl
    {
		internal Command slot; // only one button

		public SimpleRemoteControl()
		{}

		public virtual Command Command
		{
			set
			{
				// set the value the remote will 
				// execute 
				slot = value;
			}
		}

		public virtual String buttonWasPressed()
		{
			return slot.Execute();
		}
	}
}
