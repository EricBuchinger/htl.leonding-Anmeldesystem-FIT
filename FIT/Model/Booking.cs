using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Booking : EntityObject
    {
        public Event Event { get; set; }


        public Company Company { get; set; }

        public Location Location { get; set; }
        

       
        public Presentation Presentation { get; set; }

        


        public Category Category { get; set; }
        
        
        public bool isAccepted { get; set; }

    }
}
