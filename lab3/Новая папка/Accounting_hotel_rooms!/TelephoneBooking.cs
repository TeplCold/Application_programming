using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_hotel_rooms
{
    public class TelephoneBooking : Check_in
    {
        //public string phone;
        public override Check_in Copy()
        {
            return new TelephoneBooking
            {
                id = id,
                //ime = ime,
                //nome = nome,
                phone = phone,
              
                name = name,
                famil = famil,
                date = date,
                price_Number = price_Number,
                room_Number = room_Number,
               
            };
        }
    }
}