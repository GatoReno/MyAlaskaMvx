using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Microsoft.Extensions.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MyOwnAppMvx.Abstractions;
using MyOwnAppMvx.Models;
using MyOwnAppMvx.utilities;

namespace MyOwnAppMvx.ViewModels
{
    public class FlightsListViewModel : BaseNavViewModel, IMvxViewModel<FlightSearchRequest>
    {
        private readonly IFlightSearchService _flightSearchService;
        private FlightSearchRequest _request;
        private IUserDialogs _userDialogs;
        private CancellationTokenSource _cancellationTokenSource;

        public MvxObservableCollection<FlightResult> Flights { get; private set; }


        public FlightsListViewModel(ILoggerFactory logFactory,
            IMvxNavigationService navigationService,
            IFlightSearchService flightSearchService,
            IUserDialogs userDialogs) : base(logFactory, navigationService)
        {
            _flightSearchService = flightSearchService;
            _userDialogs = userDialogs;

            Title = "Flights ✈️";
            Flights = new MvxObservableCollection<FlightResult>();
        }

        public async Task RefreshFlights()
        {
            if (_cancellationTokenSource == null)
            {
                _cancellationTokenSource = new CancellationTokenSource();
            }

            IsRefreshing = true;
            var flights = await _flightSearchService.GetFlightsAsync(_request, _cancellationTokenSource.Token);
            IsRefreshing = false;

            if (flights != null && flights.Any())
            {
                Flights.Clear();
                Flights.AddRange(flights);
            }
            else
            {
                await _userDialogs.AlertAsync("No Flights", "Response", "OK");
                await NavigationService.Close(this);
            }

            _cancellationTokenSource.Token.ThrowIfCancellationRequested();
        }

        protected override async Task OnRefreshAsyncCommand()
        {
            try
            {
                await RefreshFlights();
            }
            catch (OperationCanceledException opc)
            {
                IsRefreshing = false;
                Console.WriteLine(opc.Message);
                await NavigationService.Close(this);
            }
            catch (APIErrorExc exc)
            {
                IsRefreshing = false;
                Console.WriteLine(exc.ApiError);
                await _userDialogs.AlertAsync(exc.ApiError, "Error! 😅", "OK");
                await NavigationService.Close(this);
            }
            catch (Exception ex)
            {
                IsRefreshing = false;
                Console.WriteLine(ex.Message);
                await _userDialogs.AlertAsync("Something went wrong 💀, please try again", "Error! 😅", "OK");
                await NavigationService.Close(this);
            }
            finally
            {
                _cancellationTokenSource?.Dispose();
                _cancellationTokenSource = null;
            }
        }

        public void Prepare(FlightSearchRequest parameter)
        {
            _request = parameter;
            RefreshAsyncCommand.Execute();
        }

        protected override async Task OnBackAsyncCommand()
        {
            _cancellationTokenSource?.Cancel();
            await base.OnBackAsyncCommand();
        }
    }

}
