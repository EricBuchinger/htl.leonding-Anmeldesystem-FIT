using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Presentation : EntityObject
    {
        [Required]
        public string RoomNumber { get; set; }
        [Required]
        [MaxLength(30)]
        public string Titel { get; set; }
        [Required]
        [MaxLength(400)]
        public string Description { get; set; }
        [Required]
        public bool IsAccepted { get; set; }

    }
}
