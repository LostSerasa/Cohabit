using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cohabit.Core.ViewModels
{
    public class MenuL2ViewModel: MvxViewModel
    {
        public ICommand PropertyListCommand { get; private set; }
        public ICommand PinboardCommand { get; private set; }
        public ICommand RatingCommand { get; private set; }
        public ICommand RulesCommand { get; private set; }
        public ICommand EManagementCommand { get; private set; }
        public ICommand BillListCommand { get; private set; }
        public ICommand LogOutCommand { get; private set; }
        public MenuL2ViewModel()
        {
            PropertyListCommand = new MvxCommand(() => { ShowViewModel<PropertyViewModel>(new { AccountNumber = 0 }); });
            BillListCommand = new MvxCommand(() => { ShowViewModel<BillListViewModel>(new { AccountNumber = 0 }); });
            PinboardCommand = new MvxCommand(() => { ShowViewModel<NAScreenViewModel>(new { AccountNumber = 0 }); });
            RatingCommand = new MvxCommand(() => { ShowViewModel<NAScreenViewModel>(new { AccountNumber = 0 }); });
            RulesCommand = new MvxCommand(() => { ShowViewModel<InfoPageViewModel>(new { AccountNumber = 0 }); });
            EManagementCommand = new MvxCommand(() => { ShowViewModel<NAScreenViewModel>(new { AccountNumber = 0 }); });
            LogOutCommand = new MvxCommand(() => { ShowViewModel<StartViewModel>(new { AccountNumber = 0 }); });
        }

    }
}
