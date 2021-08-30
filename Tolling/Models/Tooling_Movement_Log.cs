using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class Tooling_Movement_Log
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This Field  is required")]

         public DateTime ActionTakenAt { get; set; }
        //[f]
        public string ActionName { get; set; }
        
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

       [MaxLength(10, ErrorMessage = "SerialNumber can't be longer than 10 characters")]
        public string serialNumber { get; set; }
        [ForeignKey("serialNumber")]
        public Tool Tool { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }

    }
}
