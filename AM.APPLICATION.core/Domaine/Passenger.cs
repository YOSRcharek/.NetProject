using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.APPLICATION.core.Domaine
{
    public class Passenger
    {
        public Passenger(int id, int telNumber, string emailAdresse, DateTime birthDate, string firstName, string lastName, string passportNumber)
        {
            Id = id;
            TelNumber = telNumber;
            EmailAdresse = emailAdresse;
            BirthDate = birthDate;
            FirstName = firstName;
            LastName = lastName;
            PassportNumber = passportNumber;
        }
        public Passenger() { }  
        public int Id { get; set; }
        public int TelNumber { get; set; }
        public String EmailAdresse { get; set; }
        public DateTime BirthDate { get; set; }
        public String FirstName { get; set; }
        public String LastName{ get; set; }
        public String PassportNumber { get; set; }
        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "Id : " + Id + " TelNumber : " + TelNumber + " EmailAdresse : " + EmailAdresse +
                   " BirthDate : " + BirthDate + " FirstName : " + FirstName +
                   " LastName : " + LastName + " PassportNumber : " + PassportNumber;
        }
        public bool CheckProfile( string firstName, string lastName)
        {
            return this.FirstName == firstName && this.LastName == lastName;
        }

       public bool CheckProfile(string lastName, string firstName, string email)
        {
            return this.FirstName == firstName && this.LastName == lastName && this.EmailAdresse.Equals( email);
        }
        public bool CheckProfiles(string firstName, string lastName, string email = null)
        {
            if (email == null)
                return this.FirstName == firstName && this.LastName == lastName;
            return this.FirstName == firstName && this.LastName == lastName && this.EmailAdresse.Equals(email);

        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am Passenger");
        }



    }
}
