using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Rem.Models
{
    public class AddCentralModel
    {
        [Required]
        [StringLength(45, ErrorMessage = "Estado is too long.")]
        [MinLength(1, ErrorMessage = "Estado is too short.")]
        public string Estado { get; set; }

        [Required]
        public int Motores { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "Nome is too long.")]
        [MinLength(1, ErrorMessage = "Nome is too short.")]
        public string Nome { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "Tipo is too long.")]
        [MinLength(1, ErrorMessage = "Tipo is too short.")]
        public string Tipo { get; set; }

        [Required]
        public int Inauguracao { get; set; }

        [Required]
        public int Empresa { get; set; }

        [Required]
        public int MaxDiario { get; set; }
        
        [Required]
        public int MinDiario { get; set; }

        [Required]
        public int CoordenadaX { get; set; }

        [Required]
        public int CoordenadaY { get; set; }

        [Required]
        public string Endereco { get; set; }
    }
}
