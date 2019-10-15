using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Please enter a user name")]
        [StringLength(10, MinimumLength = 3)]
        public string UserName { get; set; }

        [MinLength(3)]
        [MaxLength(10)]
        [Required]
        public string Password { get; set; }

        [Range(18, 99)]
        public int Age { get; set; }
    }

   
}
