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
    public class Lecturer:EntityObject
    {
        [ForeignKey("FK_Person")]
        public Person Person { get; set; }

        public int FK_Person { get; set; }
        [ForeignKey("FK_Presentation")]
        public Presentation Presentation { get; set; }
        public int FK_Presentation { get; set; }
    }
}
