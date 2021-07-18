using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_for_hotel_rooms
{
    class Program
    {
        public static Studio Studio;
        
        static void Main(string[] args)
        {
            Studio = new Studio(new MemoryDataSource());

            int user = 0;
            do
            {
                try
                {
                    Menu();
                    user = int.Parse(Console.ReadLine());
                    switch (user)
                    {
                        case 1:
                            Add();
                            break;

                        case 2:
                            Change();
                            break;

                        case 3:
                            Delete();
                            break;

                        case 4:
                            Look();
                            break;
                            
                        case 5:
                            Report();
                            break;

                        case 0:
                            Console.WriteLine("  выход");
                            break;

                        default:
                            Console.WriteLine("  Такого раздела нет!");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (user != 0);
        }

///  Добавить ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------

        static void Add()
        {
            Console.WriteLine("  Выберите метод регистрации:");
            Console.WriteLine("  1 - онлаин регистрация");
            Console.WriteLine("  2 - регистрация по телефону");
            Console.WriteLine("  0 - Выход в главное меню \n");
            Console.Write("> ");
            Check_in check = null;
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                check = new TelephoneBooking();
            }
            else if (type == 2)
            {
                check = new OnlineBooking();
            }

            else if (type == 0)
            {
                throw new Exception("  выход");
            }

            else
            {
                if (type != 1 || (type != 2) || (type != 0))
                    throw new Exception("  Такого раздела нет!");
            }
            type = 0;

            if (check is TelephoneBooking)
            {
                Console.WriteLine("  Введите номер телефона(телефон должен содеражать 11 цифр):");
                Console.Write("> ");
                ((TelephoneBooking)check).phone = (Console.ReadLine());

                var reg = ((TelephoneBooking)check).phone;
                if (reg.Length < 11 || reg.Length > 11)
                {
                    throw new Exception("  Ошибка: телефон введен неверно ");
                }
            }

            else if (check is OnlineBooking)
            {
                Console.WriteLine("  Введите email (email может содержать от 8 до 21 символа:):");
                Console.Write("> ");
                ((OnlineBooking)check).email = (Console.ReadLine());

                var reg = ((OnlineBooking)check).email;
                if (reg.Length < 8 || reg.Length > 20)
                {
                    throw new Exception("  Ошибка: email введен неверно");
                }
            }


            var nam = new Name_client();
            Console.WriteLine(" ");
            Console.WriteLine("  Введите имя");
            Console.Write("> ");
            nam.name = (Console.ReadLine());
            if (nam.name.Length < 1)
            {
                throw new Exception("  Имя отсутствует!");
            }
            check.ime = nam;

            Console.WriteLine(" ");
            Console.WriteLine("  Введите фамилию");
            Console.Write("> ");
            nam.famil = (Console.ReadLine());
            if (nam.famil.Length < 1)
            {
                throw new Exception("  Фамилия отсутствует!");
            }
            check.ime = nam;


            var data = new Nomer();
            Console.WriteLine(" ");
            Console.WriteLine("  Выберите номер:");
            Console.WriteLine("  1 - Junior Suite (500р)");
            Console.WriteLine("  2 - Family Room (1000р)");
            Console.WriteLine("  3 - Standart (1200р)");
            Console.WriteLine("  4 - President Villa (2500р)");
            Console.WriteLine("  0 - Выход в главное меню");
            Console.WriteLine("  ");
            Console.Write("> ");

            data.room_Number = int.Parse(Console.ReadLine());

            if (data.room_Number == 0)
            {
                throw new Exception("  выход");
            }

            else if (data.room_Number == 1)
            {
                data.price_Number = +1000;
            }
            else if (data.room_Number == 2)
            {
                data.price_Number = +1200;
            }
            else if (data.room_Number == 3)
            {
                data.price_Number = +1600;
            }
            else if (data.room_Number == 4)
            {
                data.price_Number = +2500;
            }
            else if (data.room_Number != 0 || data.room_Number != 1 || data.room_Number != 2 || data.room_Number != 3 || data.room_Number != 4)
            {
                throw new Exception("  Такого раздела нет! ");
            }


            Console.WriteLine(" ");
            Console.WriteLine("  Введите дату и время (1 января 2000 или 1.1.2000 или 1 1 2000  )");
            Console.Write("> ");
            data.date = Convert.ToDateTime(Console.ReadLine());
            check.nome = data;

            Studio.Save(check);
        }
        

/// Изменение записи ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------
        static void Change()
        {
            Console.WriteLine("Введите id: ");
            Console.WriteLine("> ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("  Выберите метод регистрации:");
            Console.WriteLine("  1 - онлаин регистрация");
            Console.WriteLine("  2 - регистрация по телефону");
            Console.WriteLine("  0 - Выход в главное меню \n");
            Console.Write("> ");
            Check_in check = null;
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                check = new TelephoneBooking();
            }
            else if (type == 2)
            {
                check = new OnlineBooking();
            }

            else if (type == 0)
            {
                throw new Exception("  выход");
            }

            else
            {
                if (type != 1 || (type != 2) || (type != 0))
                    throw new Exception("  Такого раздела нет!");
            }
            type = 0;

            if (check is TelephoneBooking)
            {
                Console.WriteLine("  Введите номер телефона(телефон должен содеражать 11 цифр):");
                Console.Write("> ");
                ((TelephoneBooking)check).phone = (Console.ReadLine());

                var reg = ((TelephoneBooking)check).phone;
                if (reg.Length < 11 || reg.Length > 11)
                {
                    throw new Exception("  Ошибка: телефон введен неверно ");
                }
            }

            else if (check is OnlineBooking)
            {
                Console.WriteLine("  Введите email (email может содержать от 8 до 21 символа:):");
                Console.Write("> ");
                ((OnlineBooking)check).email = (Console.ReadLine());

                var reg = ((OnlineBooking)check).email;
                if (reg.Length < 8 || reg.Length > 20)
                {
                    throw new Exception("  Ошибка: email введен неверно");
                }
            }


            var nam = new Name_client();
            Console.WriteLine(" ");
            Console.WriteLine("  Введите имя");
            Console.Write("> ");
            nam.name = (Console.ReadLine());
            if (nam.name.Length < 1)
            {
                throw new Exception("  Имя отсутствует!");
            }
            check.ime = nam;

            Console.WriteLine(" ");
            Console.WriteLine("  Введите фамилию");
            Console.Write("> ");
            nam.famil = (Console.ReadLine());
            if (nam.famil.Length < 1)
            {
                throw new Exception("  Фамилия отсутствует!");
            }
            check.ime = nam;


            var data = new Nomer();
            Console.WriteLine(" ");
            Console.WriteLine("  Выберите номер:");
            Console.WriteLine("  1 - Junior Suite (500р)");
            Console.WriteLine("  2 - Family Room (1000р)");
            Console.WriteLine("  3 - Standart (1200р)");
            Console.WriteLine("  4 - President Villa (2500р)");
            Console.WriteLine("  0 - Выход в главное меню");
            Console.WriteLine("  ");
            Console.Write("> ");

            data.room_Number = int.Parse(Console.ReadLine());

            if (data.room_Number == 0)
            {
                throw new Exception("  выход");
            }

            else if (data.room_Number == 1)
            {
                data.price_Number = +1000;
            }
            else if (data.room_Number == 2)
            {
                data.price_Number = +1200;
            }
            else if (data.room_Number == 3)
            {
                data.price_Number = +1600;
            }
            else if (data.room_Number == 4)
            {
                data.price_Number = +2500;
            }
            else if (data.room_Number != 0 || data.room_Number != 1|| data.room_Number != 2|| data.room_Number != 3|| data.room_Number != 4)
            {
                throw new Exception("  Такого раздела нет! ");
            }


            Console.WriteLine(" ");
            Console.WriteLine("  Введите дату и время (1 января 2000 или 1.1.2000 или 1 1 2000  )");
            Console.Write("> ");
            data.date = DateTime.Parse(Console.ReadLine());
            check.nome = data;
            
            check.id = id;
            var che = Studio.Change(id, check);
            if (che == null) throw new NotImplementedException();
        }

/// Удалить ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------

        static void Delete()
        {
            Console.WriteLine("  Введите id для удаления: ");
            Console.Write("> ");
            int id = int.Parse(Console.ReadLine());
            var act = Studio.Delete(id);
            if (act == false) throw new NotImplementedException();
        }

///Посмотр списка ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------

        static void Look()
        {
            var check = Studio.GetList();
            foreach (var chec in check)
            {
                Console.Write("  id:");
                Console.Write(chec.id);
                
                Console.Write(" ");
                Console.Write("  Дата заезда:");
                Console.Write (chec.nome.date.ToString("d MMMM yyyy"));

              
                Console.Write(" ");
                Console.Write("   №_номера:");
                Console.Write(chec.nome.room_Number);

                Console.Write(" ");
                Console.Write("+");
                Console.Write(chec.nome.price_Number);
                Console.Write("р");

                Console.Write(" ");
                if (chec is TelephoneBooking)
                {
                    Console.Write("  номер_телефона:");
                    Console.Write(((TelephoneBooking)chec).phone);
                }
                else if (chec is OnlineBooking)
                {
                    Console.Write("  email:");
                    Console.Write(((OnlineBooking)chec).email);
                }
                
                Console.Write(" ");
                Console.Write(" Имя:");
                Console.Write(chec.ime.name);

                Console.Write(" ");
                Console.Write(" Фамилия:");
                Console.Write(chec.ime.famil);
                
                Console.Write("\n");

            }
        }
        

        /// Отчет ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------

        static void Report()
        {
            Console.WriteLine("  1 - Доход от номерного фонда за отчетный период по дням");
            Console.WriteLine("  2 - Доход от номерного фонда за все время");
            Console.WriteLine("  0 - Выход в главное меню");
            Console.Write("> ");
            int type = int.Parse(Console.ReadLine());

            if (type == 0)
            {
                throw new Exception("  выход");
            }

            else if (type == 2)
            {
                var report2 = Studio.Report2(null);
            }


            else if (type == 1)
            {
                var dataRep = new ReportItem();
                Console.WriteLine("  Введите дату за какой период нужно сформировать отчет (1 января 2000 или 1.1.2000 или 1 1 2000  )");
                Console.Write("> ");
                dataRep.dateRep = DateTime.Parse(Console.ReadLine());

                var report2 = Studio.Report2(dataRep.dateRep);
            }


            else if (type != 2 || type != 1)
            {
                Console.WriteLine("Ошибка: тип не выбран");
            }


            Console.WriteLine("  Отчет готов");

        }

        /// Меню ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------
        public static void Menu()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Учет_номеров_в_гостинице");
            Console.WriteLine(" ");
            Console.WriteLine("Выберите раздел:");
            Console.WriteLine("1.Добавить");
            Console.WriteLine("2.Изменение записи ");
            Console.WriteLine("3.Удалить ");
            Console.WriteLine("4.Посмотреть записи");
            Console.WriteLine("5.Отчет");
            Console.WriteLine("0.Выход");
            Console.WriteLine(" ");
            Console.Write("> ");
        }
    }
}
