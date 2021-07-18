using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_hotel_rooms
{
    public class Studio
    {
        private DataSource dataSource;

        public Studio(DataSource data_source)
        {
            dataSource = data_source;
        }


        /// ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------
        public Check_in Save(Check_in check)
        {

            if (check is TelephoneBooking)
            {

                if (check.phone.Length < 5 || check.phone.Length > 20)
                {
                    throw new Exception("Email веден не верно!");
                }
            }

            else if (check is TelephoneBooking)
            { 
                if (check.email.Length < 15 || check.name.Length > 15)
                {
                    throw new Exception("Номер веден не верно!");
                }
            }

            if (check.name == null || check.name.Length < 1)
            {
                throw new Exception("Имя отсутствует!");
            }

            if (check.name == null || check.famil.Length < 1)
            {
                throw new Exception("Фамилия отсутствует!");
            }
            
            if (check.name == null || check.room_Number < 0 || check.room_Number > 5)
            {
                throw new Exception("Выберите тип номера");
            }


            return dataSource.Save(check);
        }


        /// ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- -----------------------------------
        public bool Delete(int id)
        {
            return dataSource.Delete(id);
        }
        
        /// ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------
        public List<Check_in> GetList()
        {

             var check = dataSource.GetAll();

              check.Sort((a, b) =>
             {
                 if (a.date < b.date) return -1;
                 else if (a.date > b.date) return 1;

                 else
                 {
                     if (a.room_Number < b.room_Number) return -1;
                     else if (a.room_Number > b.room_Number) return 1;
                     else return 0;
                 }

             });

            
            return check;
        }


        public List<ReportItem> Report(DateTime? dataRep = null)
        {
            var re = dataSource.GetAll();

            int rep = 0;
            string rea = " ";
            string str = "";

            var s = new ReportItem();
            s.type = 1;

            foreach (Check_in r in re)
            {
                if (dataRep == null || r.date == dataRep.Value)
                {
                    if (r is TelephoneBooking) rea = "номер_телефона:" + ((TelephoneBooking)r).phone;
                    else if (r is OnlineBooking) rea = "email:" + ((OnlineBooking)r).email;




                    str = str + "+" + r.price_Number + " "
                                       + "Дата заезда:" + r.date.ToString("d MMMM yyyy") + " "
                                       + "№_номера:" + r.room_Number + " "
                                       + "Имя:" + r.name + " "
                                       + "Фамилия:" + r.famil + " "
                                       + rea + " "
                                       + "id:" + r.id + ' '
                                       + " " + Environment.NewLine;
                                      

                    rep += r.price_Number;
                }
            }
            str += Environment.NewLine + Environment.NewLine + "Итог за:" + " " + rep + "р" ;

            s.strs += str;

            return new List<ReportItem>
            {
                s,
            };
        }
    }
}










