// See https://aka.ms/new-console-template for more information
using AM.APPLICATION.core.Domaine;
using AM.APPLICATION.core.Services;

Console.WriteLine("Hello, World!");
/*Plane p1 = new Plane();
p1.Capacity = 12;
p1.ManufactureDate = new DateTime(2025, 05, 03);
p1.PlaneType =PlaneType.Boing;

Console.WriteLine(p1);
*/
Plane p2 = new Plane {Capacity=777,PlaneType=PlaneType.Airbus };
Console.WriteLine(p2);

Passenger pass = new Passenger { FirstName="yosr", LastName="charek",EmailAdresse="yosr.charek@gmail.com" };
//pass.CheckProfile(pass.FirstName, pass.LastName);
Console.WriteLine(pass.CheckProfiles("yosr", "charek", "geporke"));
Console.WriteLine(pass.CheckProfiles("yosr", "charek"));
pass.PassengerType();

Staff staff = new Staff();
staff.PassengerType();
Traveller traveller = new Traveller();
traveller.PassengerType();


//Flight f1 = new Flight { Destination = "Paris", FlightDate = new DateTime(2025, 2, 10) };
//Flight f2 = new Flight { Destination = "New York", FlightDate = new DateTime(2025, 3, 15) };

FlightMethode service = new FlightMethode();
//service.flights.Add(f1);
service.flights=TestData.listFlights;

List<DateTime> dates = service.GetFlightDates("Paris");

foreach (var date in dates)
{
    Console.WriteLine(date);
}

service.GetFlights("Destination", "Paris");
service.GetFlights("FlightId", "2");

