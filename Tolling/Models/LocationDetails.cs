using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class LocationDetails
    {[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(10, ErrorMessage = "SerialNumber can't be longer than 10 characters")]
        
        public string SerialNumber { get; set; }
        [ForeignKey("SerialNumber")]
        public Tool Tool { get; set; }
        [ForeignKey("LocationId")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int LockerId { get; set; }
        public Locker Locker { get; set; }
      
    }
}
