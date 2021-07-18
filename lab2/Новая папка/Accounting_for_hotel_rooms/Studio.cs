using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_for_hotel_rooms
{
    public class Studio
    {
        private DataSource dataSource;

        public Studio(DataSource data_source)
        {
            dataSource = data_source;
        }
        
        /// ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------
        public List<Check_in> GetList()
        {
            var check = dataSource.GetAll();

            check.Sort((a, b) =>
            {

                if (a.nome.date < b.nome.date) return -1;
                else if (a.nome.date > b.nome.date) return 1;

                else
                {
                    if (a.nome.room_Number < b.nome.room_Number) return -1;
                    else if (a.nome.room_Number > b.nome.room_Number) return 1;
                    else return 0;
                }

            });

            return check;
        }
        
        /// ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- -----------------------------------
        public bool Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("  Отсутствует id!");
            }

            return dataSource.Delete(id);
        }

        /// ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------

        public Check_in Get(int id, Check_in check)
        {

            if (id < 1)
            {
                throw new Exception("  Отсутствует id!");
            }

            return dataSource.Get(id, check);
        }

        /// ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------

        public Check_in Change(int id, Check_in check)
        {

            if (id < 1)
            {
                throw new Exception("  Отсутствует id!");
            }

            return dataSource.Get(id, check);
        }

        /// ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------

        public Check_in Save(Check_in check)
        {
            return dataSource.Save(check);
        }



        /// ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------
        
        public List<Check_in> Report2(DateTime? dataRep = null)
        {
            var re = dataSource.GetAll();
            
            string str = "";
            int rep = 0;

            
            foreach (Check_in r in re)
            {
                if (dataRep == null || r.nome.date == dataRep.Value)
                {
                    string rea = " ";

                    if (r is TelephoneBooking) rea = "номер_телефона:" + ((TelephoneBooking)r).phone;
                    else if (r is OnlineBooking) rea = "email:" + ((OnlineBooking)r).email;

                    str = str + "+" + r.nome.price_Number + " "
                              + "Дата заезда:" + r.nome.date.ToString("d MMMM yyyy") + " "
                              + "№_номера:" + r.nome.room_Number + " "
                              + "Имя:" + r.ime.name + " "
                              + "Фамилия:" + r.ime.famil + " "
                              + rea + " "
                              + "id:" + r.id + ' '
                              + " " + Environment.NewLine;

                    rep += r.nome.price_Number;
                }
               
                else if (r.nome.date != dataRep.Value)
                {
                    throw new Exception("  Дата не найдена!");
                }
            }
            str += Environment.NewLine + Environment.NewLine + "Итог за:" + " " + rep + "р";
            System.IO.Directory.CreateDirectory("D:\\Прикладное_программирование\\lab2");
            System.IO.File.WriteAllText("D:\\Прикладное_программирование\\lab2\\Report.txt", str);
            return null;

        }
    }
}

























