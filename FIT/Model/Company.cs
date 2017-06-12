using Model.Validation;
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
    public class Company : EntityObject
    {
        
        [MaxLength(30)]
        public string Name { get; set; }
        
        [MaxLength(350)]
        public string ShortDescription { get; set; }
        public Address Address { get; set; }

        public Contact Contact { get; set; }

        
        public string PhoneNumber { get; set; }
        
        public string Email { get; set; }
        
        public string Homepage { get; set; }
        public byte[] CompanySign { get; set; }

        
        public string SubjectAreas { get; set; }

        public string Comment { get; set; }

    }
}
