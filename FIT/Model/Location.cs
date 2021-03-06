﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Location : EntityObject
    {
        [Required]
        public int Number { get; set; }
        [ForeignKey("FK_Area")]
        public Area Area { get; set; }
        public int FK_Area { get; set; }
        [Required]
        public double XCoordinate { get; set; }
        [Required]
        public double YCoordinate { get; set; }
    }
}
