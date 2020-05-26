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
    public class GarageDoor
    {
        public virtual String up()
        {
            return "S-a ridicat usa garajului";
        }

        public virtual String down()
        {
            return "S-a coborat usa garajului";
        }

        public virtual String stop()
        {
            return "S-a oprit usa garajului";
        }
    }
}
