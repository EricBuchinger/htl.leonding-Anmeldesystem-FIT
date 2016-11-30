using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Event
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime RegistartionStart { get; set; }
        [Required]
        public DateTime RegistrationEnd { get; set; }
        [Required]
        public bool IsLocked { get; set; }

    }
}
