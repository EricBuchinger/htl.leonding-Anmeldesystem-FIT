using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Event : EntityObject
    {
        
        public String Date { get; set; }
        
        public String RegistrationStart { get; set; }
        
        public String RegistrationEnd { get; set; }
        
        public bool IsLocked { get; set; }

    }
}
