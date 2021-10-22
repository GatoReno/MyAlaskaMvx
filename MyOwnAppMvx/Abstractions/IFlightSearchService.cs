using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MyOwnAppMvx.Models;

namespace MyOwnAppMvx.Abstractions
{
    public interface IFlightSearchService
    {
        Task<IEnumerable<FlightResult>> GetFlightsAsync(FlightSearchRequest request, CancellationToken? token = null);
    }
}
