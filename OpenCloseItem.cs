using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Ip
{
    class OpenCloseItem
    {
        String itemName;

        public OpenCloseItem (String itemName)
        {
            this.itemName = itemName;
        }

        public virtual String open()
        {
            return "S-a deschis " + this.itemName;
        }
        public virtual String close()
        {
            return "S-a inchis " + this.itemName;
        }
    }
}
