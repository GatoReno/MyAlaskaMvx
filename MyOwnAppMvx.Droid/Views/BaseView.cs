using Android.OS;
using Android.Runtime;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;

namespace MyOwnAppMvx.Droid.Views
{
    public class BaseView<T> : MvxActivity<T> where T : MvxViewModel
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            CreateBindings();
        }

        protected virtual void CreateBindings()
        {
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
