using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class LocationDetails
    {   [Key]
        public int SerialNumber { get; set; }
        public Tool Tool { get; set; }
        [Key]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int LockerId { get; set; }
        public Locker Locker { get; set; }
    }
}
