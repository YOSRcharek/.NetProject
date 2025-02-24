using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.APPLICATION.core.Domaine;
using AM.APPLICATION.core.Interfaces;

namespace AM.APPLICATION.core.Services
{
    public class FlightMethode :IFlightMethode
    {
        public List<Flight> flights = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> flightDates = new List<DateTime>();

          /*  for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].Destination.Equals(destination))
                {
                    flightDates.Add(flights[i].FlightDate);
                }
            }
             return flightDates;
          */  
          //*****************avec Linq******************************************
          //Query return enumerabel
          var Query= from f in flights
                     where f.Destination == destination
                     select f.FlightDate;
            return Query.ToList();
          
        }

        public void GetFlights(string filterType, string filterValue)
        {
            List<Flight> filteredFlights = new List<Flight>();

            foreach (var flight in flights)
            {
                switch (filterType.ToLower())
                {
                    case "destination":
                        if (flight.Destination.Equals(filterValue ))
                            filteredFlights.Add(flight);
                        break;
                    case "departure":
                        if (flight.Departure.Equals(filterValue ))
                            filteredFlights.Add(flight);
                        break;
                    case "flightid":
                        if (int.TryParse(filterValue, out int flightId) && flight.FlightId == flightId)
                            filteredFlights.Add(flight);
                        break;
                    case "estimatedduration":
                        if (int.TryParse(filterValue, out int duration) && flight.EstimatedDuration == duration)
                            filteredFlights.Add(flight);
                        break;
                    case "flightdate":
                        if (DateTime.TryParse(filterValue, out DateTime flightDate) && flight.FlightDate.Date == flightDate.Date)
                            filteredFlights.Add(flight);
                        break;
                    case "affectivearrival":
                        if (DateTime.TryParse(filterValue, out DateTime arrivalDate) && flight.AffectiveArrival.Date == arrivalDate.Date)
                            filteredFlights.Add(flight);
                        break;
                    default:
                        Console.WriteLine($"Filtre '{filterType}' non valide.");
                        return;
                }
            }

            if (filteredFlights.Count > 0)
            {
                Console.WriteLine($"Résultats pour {filterType} = {filterValue} :");
                foreach (var flight in filteredFlights)
                {
                    Console.WriteLine(flight.ToString());
                }
            }
            else
            {
                Console.WriteLine($"Aucun vol trouvé pour {filterType} = {filterValue}.");
            }
        }

        public void ShowFlightDetails(Plane plane)
        {
            var query = from f in flights
                        where f.Plane == plane
                        select new { f.FlightDate, f.Destination };

            Console.WriteLine($"Vols pour l'avion {plane.PlaneId} :");
            foreach (var detail in query)
            {
                Console.WriteLine($"Date : {detail.FlightDate}, Destination : {detail.Destination}");
            }
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = from f in flights
                        where f.FlightDate >= startDate && f.FlightDate < startDate.AddDays(7)
                        select f;
            return query.Count();
        }

        public double DurationAverage(string destination)
        {
            var query = from f in flights
                        where f.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase)
                        select f.EstimatedDuration;
            return query.Average();
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        { //LINQ

           /* return from f in flights
                   orderby f.EstimatedDuration descending
                   select f;
           */
            //LAMBDA
            return flights.OrderByDescending(f => f.EstimatedDuration);    
        }


        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            return (from f in flight.Passengers.OfType<Traveller>()
                         orderby f.BirthDate 
                         select f).Take(3);
   
        }

        public IEnumerable<IGrouping<string, Flight>>DestinationGroupedFlights()
        {
            var query = from f in flights
                        group f by f.Destination;
                  
            foreach (var group in query)
            {
                Console.WriteLine($"Destination {group.Key}");
                foreach (var flight in group)
                {
                    Console.WriteLine($"Décollage : {flight.FlightDate}");
                }
            }
            return query;
        }

    }

}
