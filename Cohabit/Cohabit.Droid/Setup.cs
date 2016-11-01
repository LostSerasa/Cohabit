using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform;
using Cohabit.Core.Interface;
using Cohabit.Droid.Database;
using Cohabit.Core.Database;

namespace Cohabit.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Cohabit.Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void InitializeFirstChance()
        {
            Mvx.LazyConstructAndRegisterSingleton<ISqlite, SQLiteDroid>();      
            Mvx.LazyConstructAndRegisterSingleton<ICohabitDatabase, CohabitDatabase>();
            base.InitializeFirstChance();
        }
    }
}
