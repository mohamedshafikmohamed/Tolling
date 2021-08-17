using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "UserName created is required")]
        
        [MaxLength(20, ErrorMessage = "UserName can't be longer than 20 characters")]
        public string UserName { get; set; }
        [MaxLength(10, ErrorMessage = "Password can't be longer than 10 characters")]
        [Required(ErrorMessage = "Password created is required")]
        
        public string Password { get; set; }
        [Required(ErrorMessage = "Admin created is required")]
        public bool Admin { get; set; }

    }
}
