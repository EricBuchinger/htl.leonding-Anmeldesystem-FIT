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
        
        public string RoomNumber { get; set; }
        
        [MaxLength(30)]
        public string Title { get; set; }
        
        [MaxLength(400)]
        public string Description { get; set; }
        
        public bool IsAccepted { get; set; }

    }
}
