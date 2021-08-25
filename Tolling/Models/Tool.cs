using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class Tool
    {
        [Key]
        public int SerialNumber { get; set; }

        [Required(ErrorMessage = "ToolOwner  is required")]

        [MaxLength(20, ErrorMessage = "ToolOwner can't be longer than 20 characters")]
        public string ToolOwner { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }

        public int NoOfCavities { get; set; }
        public DateTime ReciviedAt { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }

        public IList<Part> ToolPart { get; set; }
    }
}
