using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Ip
{
    class Light
    {
		public virtual void on()
		{
			Console.WriteLine("S-a aprins lumina");
		}
		public virtual void off()
		{
			Console.WriteLine("S-a stins lumina");
		}
	}
}
