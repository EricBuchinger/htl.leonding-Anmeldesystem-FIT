using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Representative : Person
    {
        [Required]
        public Booking Booking { get; set; }
    }
}
