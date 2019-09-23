using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Final_Question1.Models
{
    public class Passengers
{
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "First Name")]
        public string FirstName { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Last Name")]
        public string LastName { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Seat Preference")]
        public string SeatPreference { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Reward Number")]
        public long RewardNumber { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Discount Percentage")]
        public double DiscountPercentage { get; set; }

}
}
