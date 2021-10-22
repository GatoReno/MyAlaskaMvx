using System;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MyOwnAppMvx.Abstractions;
using MyOwnAppMvx.Services;
using MyOwnAppMvx.ViewModels;

namespace MyOwnAppMvx
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterSingleton<IUserDialogs>(UserDialogs.Instance);
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IFlightSearchService, FlightAPIService>();

            RegisterAppStart<FlightSearchViewModel>();
        }

        public override Task Startup()
        {
            return base.Startup();
        }

        public override void Reset()
        {
            base.Reset();
        }
    }
}
