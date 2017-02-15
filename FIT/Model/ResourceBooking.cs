using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ResourceBooking : EntityObject
    {
        [Required]
        public Booking Booking { get; set; }
        [Required]
        public Resource Resource { get; set; }
    }
}
