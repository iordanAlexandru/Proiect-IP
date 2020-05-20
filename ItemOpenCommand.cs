using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Ip
{
    class ItemOpenCommand : Command
    {
        OpenCloseItem item;

        public ItemOpenCommand(OpenCloseItem item)
        {
            this.item = item;
        }

        public virtual String Execute ()
        {
            return this.item.open();
        }
    }
}
