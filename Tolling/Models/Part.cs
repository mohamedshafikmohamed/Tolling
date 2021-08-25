using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class Part
    {
        [Key]
        [MaxLength(15, ErrorMessage = "PartNumber can't be longer than 15 characters")]
        public string PartNumber { get; set; }

      
        [MaxLength(30, ErrorMessage = "Description can't be longer than 30 characters")]
        public string Description { get; set; }
        public IList<Tool> ToolPart { get; set; }

    }
}
