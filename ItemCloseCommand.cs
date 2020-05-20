using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Ip
{
    class ItemCloseCommand : Command
    {
        OpenCloseItem item;
        public ItemCloseCommand(OpenCloseItem item)
        {
            this.item = item;
        }

        public virtual String Execute()
        {
            return this.item.close();
        }
    }
}
