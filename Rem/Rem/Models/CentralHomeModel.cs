using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rem.Models
{
    public class CentralHomeModel
    {
        public string Estado { get; set; }

        public int Motorers { get; set; }

        public string Nome { get; set; }

        public string Tipo { get; set; }

        public int Valor { get; set; }

        public int MaximoDiario { get; set; }

        public int MinimoDiario { get; set; }

        public int Inauguracao { get; set; }

        public string Endereco { get; set; }

        public int CoordenadaX { get; set; }

        public int CoordenadaY { get; set; }

        public string Gestor_Utilizador_email { get; set; }

        public string EmpresaNome { get; set; }

        public string Ceo { get; set; }

        public string Sede { get; set; }

        public string Contacto { get; set; }

        public DateTime UltimaAtividade { get; set; }

        public string Descricao { get; set; }
    }
}

