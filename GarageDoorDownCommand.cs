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
    public class GarageDoorDownCommand : Command
    {
        GarageDoor garageDoor;
        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public virtual String Execute()
        {
            return this.garageDoor.down();
        } 
    }
}
