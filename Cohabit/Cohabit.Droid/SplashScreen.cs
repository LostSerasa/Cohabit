using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Cohabit.Droid
{
    [Activity(
        Label = "Cohabit.Droid"
        , MainLauncher = true
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
