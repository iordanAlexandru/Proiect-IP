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
    class Light
    {
		public virtual String on()
		{
			return "S-a aprins lumina";
		}
		public virtual String off()
		{
			return "S-a stins lumina";
		}
	}
}
