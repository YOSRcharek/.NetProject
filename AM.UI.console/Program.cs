// See https://aka.ms/new-console-template for more information
using AM.APPLICATION.core.Domaine;
using AM.APPLICATION.core.Services;

Console.WriteLine("Hello, World!");

// Création d'un avion
Plane p1 = new Plane { Capacity = 777, PlaneType = PlaneType.Airbus };
Console.WriteLine(p1);

// Création d'un passager
Passenger pass = new Passenger { FirstName = "Yosr", LastName = "Charek", EmailAdresse = "yosr.charek@gmail.com" };
Console.WriteLine(pass.CheckProfiles("Yosr", "Charek", "Geporke"));
Console.WriteLine(pass.CheckProfiles("Yosr", "Charek"));
pass.PassengerType();

// Création d'un staff et d'un voyageur
Staff staff = new Staff();
staff.PassengerType();
Traveller traveller = new Traveller();
traveller.PassengerType();

// Initialisation du service de gestion des vols
FlightMethode service = new FlightMethode();
service.flights = TestData.listFlights;

// Test GetFlightDates
List<DateTime> dates = service.GetFlightDates("Paris");
Console.WriteLine("Dates des vols pour Paris :");
foreach (var date in dates)
{
    Console.WriteLine(date.ToShortDateString());
}

// Test GetFlights
service.GetFlights("Destination", "Paris");
service.GetFlights("FlightId", "2");

// Test ShowFlightDetails
Plane p2 = new Plane { Capacity = 898, PlaneType = PlaneType.Boing };
service.ShowFlightDetails(p2);

// Test ProgrammedFlightNumber
int nbVols = service.ProgrammedFlightNumber(DateTime.Today);
Console.WriteLine($"Nombre de vols cette semaine : {nbVols}");

// Test DurationAverage
double moyenne = service.DurationAverage("Paris");
Console.WriteLine($"Durée moyenne des vols pour Paris : {moyenne} minutes");

Console.WriteLine("TES*****************************");
// 1. Tester OrderedDurationFlights
Console.WriteLine("=== Ordered Duration Flights ===");
foreach (var flight in service.OrderedDurationFlights())
{
    Console.WriteLine($"Flight to {flight.Destination}, Duration: {flight.EstimatedDuration} min");
}

// 2. Tester SeniorTravellers
Console.WriteLine("\n=== Senior Travellers ===");
Flight firstFlight = service.flights[0]; // Sélectionner un vol avec des passagers
foreach (var t in service.SeniorTravellers(firstFlight))
{
    Console.WriteLine($"Traveller: {t.FirstName}, BirthDate: {t.BirthDate.ToShortDateString()}");
}

// 3. Tester DestinationGroupedFlights
Console.WriteLine("\n=== Destination Grouped Flights ===");
foreach (var group in service.DestinationGroupedFlights())
{
    Console.WriteLine($"\nDestination: {group.Key}");
    foreach (var flight in group)
    {
        Console.WriteLine($"Décollage : {flight.FlightDate}");
    }
}
//Extensionnnn
pass.UpperFullName();
Console.WriteLine($"{pass.LastName} {pass.FirstName}");
