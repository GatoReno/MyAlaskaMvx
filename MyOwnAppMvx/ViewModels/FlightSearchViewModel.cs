using System;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Microsoft.Extensions.Logging;

using MvvmCross.Commands;
using MvvmCross.Navigation;
using MyOwnAppMvx.Models;

namespace MyOwnAppMvx.ViewModels

{
    public class FlightSearchViewModel : BaseNavViewModel
    {
        private string _originCode;
        private string _destinationCode;
        private DateTime _departureTime;
        private IUserDialogs _userDialogs;

        public string OriginCode
        {
            get => _originCode;
            set => SetProperty(ref _originCode, value);
        }

        public string DestinationCode
        {
            get => _destinationCode;
            set => SetProperty(ref _destinationCode, value);
        }

        public DateTime DepartureTime
        {
            get => _departureTime;
            set => SetProperty(ref _departureTime, value);
        }

        public IMvxAsyncCommand SearchAsyncCommand { get; private set; }

        public FlightSearchViewModel(ILoggerFactory logFactory,
            IMvxNavigationService navigationService,
             IUserDialogs userDialogs) : base(logFactory, navigationService)
        {
            Title = "Alaska Airlines";
            _userDialogs = userDialogs;
            SearchAsyncCommand = new MvxAsyncCommand(OnSearchAsyncCommand);
        }

        private async Task OnSearchAsyncCommand()
        {

            var request = new FlightSearchRequest()
            {
                OriginCode = OriginCode,
                DestinationCode = DestinationCode,
                DepartureTime = DepartureTime,
                ArrivalTime = DepartureTime
            };

            if (string.IsNullOrWhiteSpace(request.DestinationCode) ||
                string.IsNullOrWhiteSpace(request.OriginCode) || request.DepartureTime == null)
            {                
                _userDialogs.Toast("Data missing fill all entries");
            }
            else {
                
                await NavigationService.Navigate<FlightsListViewModel, FlightSearchRequest>(request);
            }
            
        }
    }
}
