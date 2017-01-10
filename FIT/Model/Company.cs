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
    public class Company : EntityObject
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(350)]
        public string ShortDescription { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        public Contact Contact { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [CustomValidation(typeof(EmailValidation), "EmailRules")]
        public string Email { get; set; }
        [Required]
        [CustomValidation(typeof(HomepageValidation),"LinkRules")]
        public string Homepage { get; set; }
        [Required]
        public byte[] CompanySign { get; set; }

    }
}
