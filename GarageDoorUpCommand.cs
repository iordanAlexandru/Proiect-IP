using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Autor: Blejusca Oana
 * Functionalitate: Mecanism Garaj
 */
namespace Proiect_Ip
{
    public class GarageDoorUpCommand : Command
    {
        GarageDoor garageDoor;
        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public virtual String Execute()
        {
           return this.garageDoor.up();
        }
    }
}
