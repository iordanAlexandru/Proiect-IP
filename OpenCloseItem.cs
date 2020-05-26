using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Autor: Ungureanu George
 * Functionalitate: Mecanism adaugare functionalitati ad-hoc (mai multe obiecte cu operatiune simplista)
 */
namespace Proiect_Ip
{

    //invoker clase ad-hoc
    class OpenCloseItem
    {
        String itemName;

        //Instanta a clasei OpenCloseItem ia numele obiectului care urmeaza sa se inchida / deschida
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
