using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_hotel_rooms
{

    public abstract class DataSource
    {
        abstract public Check_in Save(Check_in record);

        abstract public bool Delete(int id);

        abstract public Check_in Get(int id, Check_in record);
        
        abstract public List<Check_in> GetAll();
    }
}
