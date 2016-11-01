using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohabit.Core.Model
{
    public class PropertyTable
    {
        public PropertyTable( string address)
        {
            Address = address;
        }

        [PrimaryKey, AutoIncrement]
        public string Address { get; set; }
    }
}
