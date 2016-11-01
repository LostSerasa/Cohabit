using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohabit.Core.Model
{
    public class BillTable
    {
        public BillTable(string note, string id, string amount, /*DateTime due*/ string due)
        {
            Note = note;
            ID = id;
            Amount =  amount;
            Due =due ;
        }


        [PrimaryKey, AutoIncrement]
        public string ID { get; set; }
        public string Amount { get; set; }
        public string Note { get; set; }
        public string Due { get; set; }
        //public DateTime Due { get; set; }

    }
}
