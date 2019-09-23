using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Final_Question1.Models
{
    public class Airplane
{
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Passenger Seating Count")]
        public int PassengerSeatingCount { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Max Flight Mileage")]
        public double MaxFlightMileage { get; set; }
        public override string ToString()
        {
            return "Manufacturer: " + Manufacturer+ "  \nModel: " + Model+ "  \nPassenger Seating Count: " + PassengerSeatingCount+"  \nMax Flight Mileage: "+MaxFlightMileage;
        }
    }
}
