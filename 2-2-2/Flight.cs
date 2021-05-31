using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_2
{
    [Serializable]
    public class Flight
    {
      public  string name, destination;
      public  DateTime flying;
      public  int hrs, min, freePlace;

      public Flight(string name, string destination, DateTime flying, int hrs,int min, int freePlace)
        {
            this.name = name;
            this.destination = destination;
            this.flying = flying;
            this.hrs = hrs;
            this.min = min;
            this.freePlace = freePlace;
        }
        public Flight() { }
    }
}
