using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.APPLICATION.core.Domaine
{
    public class Traveller:Passenger
    {
        public String HealthInformation { get; set; }
        public String Nationality { get; set; }
        public Traveller() : base() { }

        public Traveller(int id, int telNumber, string emailAdresse, DateTime birthDate,
                         string firstName, string lastName, string passportNumber,
                         string healthInformation, string nationality)
            : base(id, telNumber, emailAdresse, birthDate, firstName, lastName, passportNumber)
        {
            HealthInformation = healthInformation;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return base.ToString() + " HealthInformation: " + HealthInformation +
                   " Nationality: " + Nationality;
        }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am Traveller member");
        }
    }
}

