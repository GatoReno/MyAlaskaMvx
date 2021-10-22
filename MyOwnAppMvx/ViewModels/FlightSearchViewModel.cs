using System;
using System.Threading.Tasks;
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
            IMvxNavigationService navigationService) : base(logFactory, navigationService)
        {
            Title = "Alaska Airlines";
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
            await NavigationService.Navigate<FlightsListViewModel, FlightSearchRequest>(request);
        }
    }
}
