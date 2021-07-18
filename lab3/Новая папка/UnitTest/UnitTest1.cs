using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Accounting_hotel_rooms;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Add()
        {
            var memory = new MemoryDataSource();

            var studio = new Studio(memory);

            var check = new OnlineBooking
            {
                email = "cold@mail.ru",
                name = "rthrth",
                famil = "rthfgnt",
                room_Number = 1,
            };
            

            var test = studio.Save(check);

            var list = studio.GetList();

            Assert.AreEqual(list.Count, 1);
            Assert.AreEqual(list[0].email, check.email);
            Assert.AreEqual(list[0].name, check.name);
            Assert.AreEqual(list[0].famil, check.famil);
            Assert.AreEqual(list[0].room_Number, check.room_Number);
            Assert.AreEqual(test.id, 1);
        }
    }  


 