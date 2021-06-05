using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Rem.Models
{
    public class UtilizadorModel
    {
        [Required]
        [StringLength(45, ErrorMessage = "Nome is too long.")]
        [MinLength(1, ErrorMessage = "Nome is too short.")]
        public string Nome{ get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Passs is too long.")]
        [MinLength(3, ErrorMessage = "Pass Name is too short.")]
        public string Pass { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
