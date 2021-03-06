﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Address : EntityObject
    {
        
        [Required]
        [MaxLength(25)]
        public string City { get; set; }
        [Required]
        [MaxLength(7)]
        public string PostalCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string Street { get; set; }
        [Required]
        [MaxLength(5)]
        public string  Number { get; set; }
    }
}
