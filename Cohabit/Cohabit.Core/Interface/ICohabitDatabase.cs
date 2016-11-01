using Cohabit.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohabit.Core.Interface
{
    public interface ICohabitDatabase
    {
        Task<IEnumerable<BillTable>> GetBill();
        Task<IEnumerable<BillTable>> GetAddress();

        Task<int> DeleteBill(object id);
    }
}
