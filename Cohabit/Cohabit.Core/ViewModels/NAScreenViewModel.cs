using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace Cohabit.Core.ViewModels
{
    public class NAScreenViewModel:MvxViewModel
    {
        public ICommand BackCommand { get; private set; }

        public NAScreenViewModel()
        {
            BackCommand = new MvxCommand(() =>
            {
                Close(this);
            });
        }
    }
}
