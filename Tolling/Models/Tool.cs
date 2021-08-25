using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class Tool
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [MaxLength(10, ErrorMessage = "SerialNumber can't be longer than 10 characters")]
        public string SerialNumber { get; set; }

        [Required(ErrorMessage = "ToolOwner  is required")]

        [MaxLength(20, ErrorMessage = "ToolOwner can't be longer than 20 characters")]
        public string ToolOwner { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }

        public int NoOfCavities { get; set; }
        public DateTime ReciviedAt { get; set; }

        public virtual IList<Part> ToolPart { get; set; }
    }
}
