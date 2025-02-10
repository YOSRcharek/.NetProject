using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.APPLICATION.core.Domaine;

namespace AM.APPLICATION.core.Interfaces
{
    public interface IFlightMethode

    {
        public List<DateTime> GetFlightDates(string destination);
        public void GetFlights(string filterType, string filterValue);
        public void ShowFlightDetails(Plane plane);
        public int ProgrammedFlightNumber(DateTime startDate);
        public double DurationAverage(string destination);
        public List<Flight> OrderedDurationFlights();
        public List<Passenger> SeniorTravellers(Flight flight);
    }
}