using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Ip
{
    class Stereo
    {
		public virtual void on()
		{
			Console.WriteLine("Boxele sunt pornite");
		}
		public virtual void off()
		{
			Console.WriteLine("Boxele sunt oprite");
		}
		public virtual void setCD()
		{
			Console.WriteLine("Boxele citesc fisiere media de pe  " + "CD");
		}
		public virtual void setDVD()
		{
			Console.WriteLine("Boxele citesc fisiere media de pe  " + " DVD");
		}
		public virtual void setRadio()
		{
			Console.WriteLine("Boxele sunt conectate la" + " Radio");
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
