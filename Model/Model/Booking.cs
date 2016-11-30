using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Booking
    {
        public int Id { get; set; }
        [Required]
        public Event Event { get; set; }
        [Required]
        public Company Company { get; set; }
        [Required]
        public Location Location { get; set; }
        public Presentation Presentation { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        public int Category { get; set; }
        [Required]
        public bool isAccepted { get; set; }

    }
}
