using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite.Net;
using Cohabit.Core.Interface;
using Cohabit.Core.Model;
using MvvmCross.Platform;
using System.Threading.Tasks;
namespace Cohabit.Core.Database
{
    public class CohabitDatabase : ICohabitDatabase
    {
        private SQLiteConnection database;
        private ISqlite sqlite;

        public CohabitDatabase()
        {
            var sqlite = Mvx.Resolve<ISqlite>();
            database = sqlite.GetConnection();
            
            database.CreateTable<PropertyTable>();
            
            database.CreateTable<BillTable>();
            
        }

        public CohabitDatabase(ISqlite sqlite)
        {
            this.sqlite = sqlite;
        }

        public async Task<IEnumerable<BillTable>> GetBill()
        {
            return database.Table<BillTable>().ToList();
        }

        public async Task<IEnumerable<PropertyTable>> GetAddress()
        {
            return database.Table<PropertyTable>().ToList();
        }
        public async Task<int> DeleteBill(object id)
        {
            return database.Delete<BillTable>(Convert.ToInt16(id));
        }

        
       /* public string GetValue(string id)
         {
             return  database.Table<BillTable>().Where(x => x.ID == id).FirstOrDefault().Value;
         }*/

         public int InsertOrUpdate(BillTable billTable)
        {
            return database.InsertOrReplace(billTable);
        }

         public bool DataExists(string id)
        {
            return database.Table<BillTable>().Any(x => x.ID == id);
        }

        internal void InsertBill(BillTable bill1)
        {
            throw new NotImplementedException();
        }

        internal void InsertAddress(PropertyTable property1)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<BillTable>> ICohabitDatabase.GetBill()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<BillTable>> ICohabitDatabase.GetAddress()
        {
            throw new NotImplementedException();
        }

        Task<int> ICohabitDatabase.DeleteBill(object id)
        {
            throw new NotImplementedException();
        }
    }
}
