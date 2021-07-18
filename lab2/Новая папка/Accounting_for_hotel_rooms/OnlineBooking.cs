using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_for_hotel_rooms
{
    public class OnlineBooking : Check_in
    {
        public string email;

        public override Check_in Copy()
        {
            return new OnlineBooking
            {
                id = id,
                ime = ime,
                nome = nome,
                email = email,
            };
        }
    }
}