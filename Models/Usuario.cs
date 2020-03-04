using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TRACKR.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int AceitouTermosUso { get; set; }
        public int AceitouTermosParceiros { get; set; }
        public int Pais { get; set; }
        public string Profissao { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public NivelDoUsuario Nivel { get; set; }
    }
}
