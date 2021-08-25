using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class Locker
    {
        [Key]
        public int LockerId { get; set; }

        [Required(ErrorMessage = "LockerName  is required")]

        [MaxLength(10, ErrorMessage = "LockerName can't be longer than 10 characters")]
        public string LockerName { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
    }
}
