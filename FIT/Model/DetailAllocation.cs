using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DetailAllocation 
    {
        public int Id { get; set; }
        [Required]
        public Detail Detail { get; set; }
        [Required]
        public Booking Booking { get; set; }
        [Required]
        [MaxLength(30)]
        public string Text { get; set; }
    }
}
