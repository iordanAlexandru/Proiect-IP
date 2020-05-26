using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Autor: Amariei Marinel
 * Functionalitate: Mecanism lumina
 */
namespace Proiect_Ip
{
    class LightOnCommand : Command
	{
			internal Light light;
			public LightOnCommand(Light light)
			{
				this.light = light;
			}
			public virtual String Execute()
			{
				return light.on();
			}
	}
}
