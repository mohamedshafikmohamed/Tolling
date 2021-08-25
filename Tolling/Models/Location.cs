using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required(ErrorMessage = "LocationName  is required")]

        [MaxLength(20, ErrorMessage = "LocationName can't be longer than 20 characters")]
        public string LocationName { get; set; }
    }
}
