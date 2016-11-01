using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cohabit.Core.ViewModels
{
    public class MenuL1ViewModel : MvxViewModel
    {
        public ICommand PropertyListCommand { get; private set; }

        public ICommand LogOutCommand { get; private set; }
        public MenuL1ViewModel()
        {
            PropertyListCommand = new MvxCommand(() => { ShowViewModel<PropertyViewModel>(new { AccountNumber = 0 }); });

            LogOutCommand = new MvxCommand(() => { ShowViewModel<StartViewModel>(); });
        }
    }
}
