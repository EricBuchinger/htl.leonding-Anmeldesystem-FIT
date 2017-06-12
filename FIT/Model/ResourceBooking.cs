using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ResourceBooking : EntityObject
    {
        public Booking Booking { get; set; }

    

        public Resource Resource { get; set; }
  
        
        public int Amount { get; set; }
    }
}
