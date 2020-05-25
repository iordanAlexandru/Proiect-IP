using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Ip
{ // invoker
    class SimpleRemoteControl
    {
		internal Command slot; //butonul

		public SimpleRemoteControl()
		{}

		public virtual Command Command
		{
			set
			{
				//setez valoarea butonului pe care il voi executa
				slot = value;
			}
		}

		public virtual String buttonWasPressed()
		{
			return slot.Execute();
		}
	}
}
