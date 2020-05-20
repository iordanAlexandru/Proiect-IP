using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Ip
{
    class Stereo
    {
		public virtual String on()
		{
			return "Boxele sunt pornite";
		}
		public virtual String off()
		{
			return "Boxele sunt oprite";
		}
		public virtual String setCD()
		{
			return "Boxele citesc fisiere media de pe  " + "CD";
		}
		public virtual String setDVD()
		{
			return "Boxele citesc fisiere media de pe  " + " DVD";
		}
		public virtual String setRadio()
		{
			return "Boxele sunt conectate la" + " Radio";
		}
		public virtual int Volume
		{
			set
			{
				// code to set the value 
				Console.WriteLine("Volumul boxelor este setat" + " la " + value);
			}
		}
	}
}
