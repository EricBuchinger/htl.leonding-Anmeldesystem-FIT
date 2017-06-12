using System;
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

        public Person Person { get; set; }

  
        public Presentation Presentation { get; set; }
       
    }
}
