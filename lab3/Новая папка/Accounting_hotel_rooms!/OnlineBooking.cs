using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_hotel_rooms
{
    public class OnlineBooking : Check_in
    {
       // public string email;
        public override Check_in Copy()
        {
            return new OnlineBooking
            {
                id = id,
                //ime = ime,
                //nome = nome,
                email = email,
                
                name = name,
                famil = famil,
                date = date,
                price_Number = price_Number,
                room_Number = room_Number,
              
            };
        }
    }
}