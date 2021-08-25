using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class LocationDetails
    { /*  [Key]

        [MaxLength(10, ErrorMessage = "SerialNumber can't be longer than 10 characters")]
        public string SerialNumber { get; set; }
        public Tool Tool { get; set; }*/
        [Key]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int LockerId { get; set; }
        public Locker Locker { get; set; }
    }
}
