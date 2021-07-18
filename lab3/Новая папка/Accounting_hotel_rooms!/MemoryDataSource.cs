using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_hotel_rooms
{
    public class MemoryDataSource : DataSource
    {
        private List<Check_in> check_ins = new List<Check_in>();
        private int idCounter = 0;

        private int FindIndex(int id)
        {
            for (var i = 0; i < check_ins.Count; i++)
            {
                if (check_ins[i].id == id) return i;
            }
            return -1;
        }
        
        public override Check_in Get(int id, Check_in record)
        {
            var nw = record;
            int ind = FindIndex(id);
            check_ins[ind] = nw;
            return nw;
        }
        
        public override Check_in Save(Check_in record)
        {
            var copy = record.Copy();

            if (record.id != null)
            {
                int ind = FindIndex(record.id.Value);
                if (ind != -1)
                {
                    check_ins[ind] = copy;
                    return copy;
                }
            }

            copy.id = ++idCounter;
            check_ins.Add(copy);
            return copy;
        }

        public override bool Delete(int id)
        {
            int ind = FindIndex(id);
            if (ind != -1)
            {
                check_ins.RemoveAt(ind);
                return true;
            }
            return false;
        }

        public override List<Check_in> GetAll()
        {
            var new_list = new List<Check_in>();
            foreach (var check in check_ins)
            {
                new_list.Add(check.Copy());
            }
            return new_list;
        }

        

    }
}
