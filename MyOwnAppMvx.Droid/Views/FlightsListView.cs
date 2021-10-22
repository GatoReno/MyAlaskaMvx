using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MyOwnAppMvx.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace MyOwnAppMvx.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Theme = "@style/AppTheme")]
    public class FlightsListView : BaseView<FlightsListViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.flights_list_view);
            SupportActionBar?.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar?.SetDisplayShowHomeEnabled(true);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    ViewModel.BackAsyncCommand.Execute();
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }

        protected override void CreateBindings()
        {
            var set = this.CreateBindingSet<FlightsListView, FlightsListViewModel>();
            set.Bind(SupportActionBar).For(v => v.Title).To(vm => vm.Title);
            set.Apply();
        }
    }
}
