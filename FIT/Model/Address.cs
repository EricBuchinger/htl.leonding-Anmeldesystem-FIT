using System;
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
        
        
        [MaxLength(25)]
        public string City { get; set; }
        
        [MaxLength(7)]
        public string PostalCode { get; set; }
        
        [MaxLength(50)]
        public string Street { get; set; }
        
        [MaxLength(5)]
        public string  Number { get; set; }
    }
}
