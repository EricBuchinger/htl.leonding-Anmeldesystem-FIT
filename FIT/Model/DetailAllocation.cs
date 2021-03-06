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
    public class DetailAllocation : EntityObject
    {
        [ForeignKey("FK_Detail")]
        public Detail Detail { get; set; }
        public int FK_Detail { get; set; }

        [ForeignKey("FK_Booking")]
        public Booking Booking { get; set; }
        public int FK_Booking { get; set; }
        [Required]
        [MaxLength(30)]
        public string Text { get; set; }
    }
}
