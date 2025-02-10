using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.APPLICATION.core.Domaine;
using AM.APPLICATION.core.Interfaces;

namespace AM.APPLICATION.core.Services
{
    public class PlaneMethode : IPlaneMethode
    {
        public List<Flight> flights = new List<Flight>();
        public void ShowFlightDetails(Plane plane)
        {
           
                var flightDetails = flights
                    .Where(f => f.Plane == plane)
                    .Select(f => new { f.FlightDate, f.Destination });

                Console.WriteLine($"Vols pour l'avion {plane.PlaneId} :");
                foreach (var detail in flightDetails)
                {
                    Console.WriteLine($"Date : {detail.FlightDate}, Destination : {detail.Destination}");
                }
            
        }
    }
}
