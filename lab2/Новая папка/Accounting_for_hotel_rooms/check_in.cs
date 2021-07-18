using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_for_hotel_rooms
{
    public abstract class Check_in
    {
        public int? id;

        public Name_client ime;
        public Nomer nome;

        abstract public Check_in Copy();
    }
}
