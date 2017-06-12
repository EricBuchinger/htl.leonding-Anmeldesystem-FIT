using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Resource : EntityObject
    {
        
        [MaxLength(25)]
        public string Name { get; set; }
        
        [MaxLength(150)]
        public string Description { get; set; }

    }
}
