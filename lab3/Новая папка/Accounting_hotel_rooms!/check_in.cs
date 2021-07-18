using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_hotel_rooms
{
    public abstract class Check_in
    {
        public int? id;

      //  public Name_client ime;
      //  public Nomer nome;

        public string phone;
        public string email;

       
        public string name;
        public string famil;

   
        public DateTime date;
        public int price_Number;
        public int room_Number;

        abstract public Check_in Copy();
    }
}
