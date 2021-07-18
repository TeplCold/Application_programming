using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting_hotel_rooms;

namespace Accounting_hotel_rooms_Windows
{
    static class Program
    {
        public static Studio Studio;
        
        [STAThread]
        static void Main()
        {

            Studio = new Studio(new MemoryDataSource());
            
            Studio.Save(new TelephoneBooking
            {
                phone = "8(950)836–46–92",
                room_Number = 1 ,
                name = "sdbbd",
                famil = "asdbd",
                price_Number= 1000,
            });

            Studio.Save(new OnlineBooking
            {
                email = "cold@mail.ru",
                room_Number = 1,
                name = "sdbbd",
                famil = "asdbd",
                price_Number = 1000,
            });


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
