using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class ToolPart
    {
        [Key]
        [MaxLength(15, ErrorMessage = "PartNumber can't be longer than 15 characters")]
        public string PartNumber { get; set; }
        public Part Part { get; set; }
        [Key]
        public int SerialNumber { get; set; }
        public Tool Tool { get; set; }


    }
}
