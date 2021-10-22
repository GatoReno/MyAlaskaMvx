using System;
using System.Collections.Generic;
using System.Linq;

namespace MyOwnAppMvx.Models
{
    public static class FlightConverter
    {
        public static IList<FlightResult> ToFlights(this FlightResponse response)
        {
            var flights = new List<FlightResult>();

            if (response != null && response.Flights != null)
            {
                foreach (var flight in response.Flights)
                {
                    if (flight.FlightDetails != null)
                    {
                        var leg = flight.FlightDetails.FlightLegs.First();

                        flights.Add(new FlightResult()
                        {
                            FlightNumber = flight.FlightDetails.OperatingFlightNumber,
                            OriginCode = leg.ActualDepartureStation.AirportCode,
                            DestinationCode = leg.ActualArrivalStation.AirportCode,
                            DepartureTime = leg.EstimatedDateTimeUTC.Out,
                            ArrivalTime = leg.EstimatedDateTimeUTC.In
                        });
                    }
                }
            }

            return flights;
        }
    }
}
