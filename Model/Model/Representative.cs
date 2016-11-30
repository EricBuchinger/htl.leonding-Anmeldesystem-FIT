﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Representative
    {
        public int Id { get; set; }
        [Required]
        public Booking Booking { get; set; }
        [Required]
        public Person Person { get; set; }

    }
}
