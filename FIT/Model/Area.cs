using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Area 
    {
        public int Id { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public byte[] Graphic { get; set; }
        [Required]
        public Event Event { get; set; }

    }
}
