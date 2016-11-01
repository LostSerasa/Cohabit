using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cohabit.Core.ViewModels
{
  
    public class MenuT1ViewModel:MvxViewModel
    {
        public ICommand PinboardCommand { get; private set; }
        public ICommand RatingCommand { get; private set; }
        public ICommand RulesCommand { get; private set; }
        public ICommand EManagementCommand { get; private set; }
        public ICommand BillListCommand { get; private set; }
        public ICommand LogOutCommand { get; private set; }
        public MenuT1ViewModel()
        { 
        BillListCommand = new MvxCommand(() => { ShowViewModel<BillListViewModel>(new { AccountNumber = 1 }); });
        PinboardCommand = new MvxCommand(() => { ShowViewModel<NAScreenViewModel>(new { AccountNumber = 1 }); });
        RatingCommand = new MvxCommand(() => { ShowViewModel<NAScreenViewModel>(new { AccountNumber = 1 }); });
        RulesCommand = new MvxCommand(() => { ShowViewModel<InfoPageViewModel>(new { AccountNumber = 1 }); });
        EManagementCommand = new MvxCommand(() => { ShowViewModel<NAScreenViewModel>(new { AccountNumber = 1 }); });
        LogOutCommand = new MvxCommand(() => { ShowViewModel<StartViewModel>(new { AccountNumber = 1 }); });
        }
    }
}
