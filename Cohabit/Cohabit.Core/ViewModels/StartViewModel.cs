using Cohabit.Core.Database;
using Cohabit.Core.Interface;
using MvvmCross.Core.ViewModels;
using Cohabit.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cohabit.Core.ViewModels
{
    
    public class StartViewModel: MvxViewModel
    {
    const string FIRST_RUN = "FirstRun";
    ISqlite sqlite;
    public int AccountNumber = 0;
    public ICommand TenantLogCommand { get; private set; }
    public ICommand LandlordLogCommand { get; private set; }
    public StartViewModel()
        {
            TenantLogCommand = new MvxCommand(() => {ShowViewModel<InfoPageViewModel>(new { AccountNumber = 1 }); });
            LandlordLogCommand = new MvxCommand(() => { ShowViewModel<PropertyViewModel>(new { AccountNumber = 0}); });
            
        }

       public override void Start()
        {
            base.Start();

            //datbase stuff below i can't get it to work
          /*  var database = new CohabitDatabase(sqlite);


            if (!database.DataExists("FirstRun"))
            {
                //Database has insertion of 'FirstRun'
                //database.InsertOrUpdate(new Model.BillTable { ID = FIRST_RUN, Value = "Y" });

                var billDatabase = new CohabitDatabase(sqlite);

                var Bill1 = new BillTable("", "0", "120.00", "12/03/2022");
                billDatabase.InsertBill(Bill1);
                var property1 = new PropertyTable("5 Notahouse street");
                billDatabase.InsertAddress(property1);

               
            }*/
        }
    }
}
