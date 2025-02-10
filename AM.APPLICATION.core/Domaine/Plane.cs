using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.APPLICATION.core.Domaine
{
    public class Plane
    {
       /* public Plane(int capacity, int planeId, DateTime manufactureDate)
        {
            Capacity = capacity;
            PlaneId = planeId;
            ManufactureDate = manufactureDate;
        }
        public Plane()
        {
        }*/

        #region

        // light version

        /*  // secure version
          public int Capacity1
          {
              get;private set;
          }
          // full version
          private int myVar;

          public int capacity2
          {
              get { return myVar; }
              set { myVar = value; }
          }

          */

        #endregion

        public int Capacity{ get; set;}
        public int PlaneId { get; set; }
        public DateTime ManufactureDate { get; set; }

        public PlaneType PlaneType { get; set; }
        public IList<Flight> Flights{ get; set; }

        public override string ToString()
        {
            return "Capacity : "+ Capacity+" Manufacture : "+ManufactureDate+" PlaneType : "+PlaneType;
        }

        
    }
}