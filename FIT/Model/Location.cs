using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Location
    {
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public Area Area { get; set; }
        [Required]
        public double XCoordinate { get; set; }
        [Required]
        public double YCoordinate { get; set; }
    }
}
