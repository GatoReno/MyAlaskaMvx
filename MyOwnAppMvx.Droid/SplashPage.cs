using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;
namespace MyOwnAppMvx.Droid
{
   
    [Activity(
        Label = "@string/app_name"
        , MainLauncher = true
        , Theme = "@style/AppTheme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashPage : MvxSplashScreenActivity
    {
        public SplashPage()
            : base(Resource.Layout.splash_screen)
        {
        }
    }
}
