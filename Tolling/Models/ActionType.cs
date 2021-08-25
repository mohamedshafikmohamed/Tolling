using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class ActionType
    {
        [Key]
        [MaxLength(20, ErrorMessage = "ActionName can't be longer than 20 characters")]
        public string ActionName { get; set; }
    }
}
