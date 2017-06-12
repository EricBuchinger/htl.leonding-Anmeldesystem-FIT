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
    public class Location : EntityObject
    {
        
        public int Number { get; set; }
      
        public Area Area { get; set; }
       
        
        public double XCoordinate { get; set; }
        
        public double YCoordinate { get; set; }
    }
}
