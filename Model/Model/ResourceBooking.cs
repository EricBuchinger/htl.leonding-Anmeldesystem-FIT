using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ResourceBooking
    {
        public int Id { get; set; }
        [Required]
        public Booking Booking { get; set; }
        [Required]
        public Resource Resource { get; set; }
    }
}
