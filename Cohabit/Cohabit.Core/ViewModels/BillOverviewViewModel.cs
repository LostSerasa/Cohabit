using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cohabit.Core.ViewModels
{
    public class BillOverviewViewModel : MvxViewModel
    {
        private int accountNumber;
        public ICommand EditBillCommand { get; private set; }
        public ICommand DeleteBillCommand { get; private set; }
        public ICommand MenuCommand { get; private set; }
        public BillOverviewViewModel()
        {

            EditBillCommand = new MvxCommand(() => { ShowViewModel<BillDataViewModel>(); });
            DeleteBillCommand = new MvxCommand(() =>
            {
                Close(this);
            });

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

