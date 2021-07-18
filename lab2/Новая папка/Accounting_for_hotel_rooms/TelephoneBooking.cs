using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_for_hotel_rooms
{
    public class TelephoneBooking : Check_in
    {
        public string phone;

        public override Check_in Copy()
        {
            return new TelephoneBooking
            {
                id = id,
                ime = ime,
                nome = nome,
                phone = phone,
            };
        }
    }
}