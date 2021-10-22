using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyOwnAppMvx.Abstractions;
using MyOwnAppMvx.Models;
using MyOwnAppMvx.utilities;

namespace MyOwnAppMvx.Services
{
    public class FlightAPIService : IFlightSearchService
    {
        private const string Key = "Ocp-Apim-Subscription-Key";
        private readonly string _serviceUrl;
        private readonly string _keyValue;

        private HttpClient _httpClient;

        public FlightAPIService()
        {            
            _serviceUrl = Constants.AAURL;
            _keyValue = Constants.AAKey;
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<FlightResult>> GetFlightsAsync(FlightSearchRequest request, CancellationToken? token = null)
        {
            IList<FlightResult> flights = null;
            var departure = request.DepartureTime.ToString("yyyy-MM-dd");
            var arrival = request.ArrivalTime.ToString("yyyy-MM-dd");
            var requestUri = new Uri($"{_serviceUrl}/flights?fromDate={departure}&toDate={arrival}&origin={request.OriginCode}&destination={request.DestinationCode}&nonStopOnly=false");
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, requestUri);

            _httpClient.DefaultRequestHeaders.Add(Key, _keyValue);
            HttpResponseMessage response = null;

            if (token.HasValue)
            {
                response = await _httpClient.SendAsync(httpRequest, token.Value);
            }
            else
            {
                response = await _httpClient.SendAsync(httpRequest);
            }

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                FlightResponse apiResponse = await Task.Run(() =>
                {
                    var apiResponse = json.FromJson<FlightResponse>();
                    return apiResponse;
                });

                return apiResponse.ToFlights();
            }
            else
            {
                StringBuilder errorMessage = new StringBuilder();
                try
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var errors = content.FromJson<IList<string>>();
                    foreach (var error in errors)
                    {
                        errorMessage.Append(error);
                    }
                    Console.WriteLine($"{content}, status: {response.StatusCode}");
                }
                catch (Exception)
                {
                }

                throw new APIErrorExc(errorMessage.ToString(), response.StatusCode);
            }

            return flights ?? new List<FlightResult>();
        }


    }

}
