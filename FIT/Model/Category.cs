using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;

namespace Model
{
    public class Category: EntityObject
    {
        [Required]
        string Name { get; set; }
        [Required]
        double Price { get; set; }
        [Required]
        string Description { get; set; }

    }
}
