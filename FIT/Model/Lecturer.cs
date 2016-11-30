using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Lecturer
    {
        public int Id { get; set; }
        [Required]
        public Person Person { get; set; }
        [Required]
        public Presentation Presentation { get; set; }
    }
}
