using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Cohabit.Core.ViewModels
{
    public class BillListViewModel : MvxViewModel
    {
        private int accountNumber;

        public ICommand AddBillCommand { get; private set; }
        public ICommand MenuCommand { get; private set; }
        public ICommand ProceedCommand { get; private set; }
        public BillListViewModel()
        {
            AddBillCommand = new MvxCommand(() => { ShowViewModel<BillDataViewModel>(); });
            MenuCommand = new MvxCommand(() =>
            {
                if (accountNumber == 1) { ShowViewModel<MenuT1ViewModel>(); }
                else { ShowViewModel<MenuL2ViewModel>(); }

            });
        }
        public void Init(int AccountNumber)
        {
            accountNumber = AccountNumber;
        }
    }
}
