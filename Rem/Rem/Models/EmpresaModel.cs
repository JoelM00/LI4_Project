using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Rem.Models
{
    public class EmpresaModel
    {
        [Required]
        [StringLength(45, ErrorMessage = "Nome is too long.")]
        [MinLength(1, ErrorMessage = "Nome is too short.")]
        public string Nome { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "Ceo is too long.")]
        [MinLength(1, ErrorMessage = "Ceo is too short.")]
        public string Ceo { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Sede is too long.")]
        [MinLength(3, ErrorMessage = "Sede Name is too short.")]
        public string Sede { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "PassEspecial is too long.")]
        [MinLength(3, ErrorMessage = "PassEspecial Name is too short.")]
        public string PassEspecial { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Contacto is too long.")]
        [MinLength(3, ErrorMessage = "Contacto Name is too short.")]
        public string Contacto { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Descricao is too long.")]
        [MinLength(3, ErrorMessage = "Descricao is too short.")]
        public string Descricao { get; set; }
    }
}