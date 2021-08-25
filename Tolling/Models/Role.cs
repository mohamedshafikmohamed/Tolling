using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class Role
    {
        [Key]

        [MaxLength(20, ErrorMessage = "RoleName can't be longer than 0 characters")]
        public string RoleName { get; set; }
        public virtual IList<User> User { get; set; }
    }
}
