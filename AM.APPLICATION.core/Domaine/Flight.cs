using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.APPLICATION.core.Domaine
{
    public class Flight
    {
        public Flight(int estimatedDuration, int flightId, string departure, string destination, DateTime affectiveArrival, DateTime flightDate)
        {
            EstimatedDuration = estimatedDuration;
            FlightId = flightId;
            Departure = departure;
            Destination = destination;
            AffectiveArrival = affectiveArrival;
            FlightDate = flightDate;
        }
        public Flight() { }
        public int EstimatedDuration { get; set; }
        public int FlightId { get; set; }
        public String Departure { get; set; }
        public String Destination { get; set; }
        public DateTime AffectiveArrival { get; set; }
        public DateTime FlightDate { get; set; }
        //property navigation
        public Plane  Plane { get; set; }
        public ICollection<Passenger> Passengers { get; set; }

        public override string ToString()
        {
            return "FlightId: " + FlightId + " Departure: " + Departure +
                   " Destination: " + Destination + " FlightDate: " + FlightDate +
                   " EstimatedDuration: " + EstimatedDuration + " AffectiveArrival: " + AffectiveArrival;
        }
    }
}
