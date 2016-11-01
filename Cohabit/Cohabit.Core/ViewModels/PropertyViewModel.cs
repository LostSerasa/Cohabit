using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cohabit.Core.Interface;
using Cohabit.Core.Database;
using System.Collections.ObjectModel;
using Cohabit.Core.Model;

namespace Cohabit.Core.ViewModels
{
    public class PropertyViewModel:MvxViewModel
    {
        
        public ICommand MenuCommand { get; private set; }
        public ICommand ProceedCommand { get; private set; }

        public void listgen()
        {
            
        }
        public PropertyViewModel( ISqlite sqlite)
        {
            MenuCommand = new MvxCommand(() => { ShowViewModel<MenuL1ViewModel>(new { AccountNumber = 0 }); });
            ProceedCommand = new MvxCommand(() => { ShowViewModel<InfoPageViewModel>(new { AccountNumber = 0 }); });


            
        }

        
         




    }

}
