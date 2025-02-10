using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.APPLICATION.core.Domaine
{
    public class Staff:Passenger
    {
        

        public DateTime EmployementDate { get; set; }
        public String Function { get; set; }
        public Double Salary { get; set; }

        public Staff() : base() { }

        public Staff(int id, int telNumber, string emailAdresse, DateTime birthDate,
                     string firstName, string lastName, string passportNumber,
                     DateTime employmentDate, string function, double salary)
            : base(id, telNumber, emailAdresse, birthDate, firstName, lastName, passportNumber)
        {
            EmployementDate = employmentDate;
            Function = function;
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + " EmploymentDate: " + EmployementDate +
                   " Function: " + Function + " Salary: " + Salary;
        }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am staff member");
        }
       



    }


}
