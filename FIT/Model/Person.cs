using Model.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person : EntityObject
    {
        
        [MaxLength(25)]
        public string FirstName { get; set; }
        
        [MaxLength(25)]
        public string LastName { get; set; }
        
        public string Email { get; set; }
       
        public byte[] Picture { get; set; }
        
        public string PhoneNumber { get; set;}
    }
}
