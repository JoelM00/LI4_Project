using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rem.Models
{
    public class MapaCentralModel
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }

        public string Tipo { get; set; }

        public int CoordenadaX { get; set; }

        public int CoordenadaY { get; set; }

        public string Endereco { get; set; }
    }
}
