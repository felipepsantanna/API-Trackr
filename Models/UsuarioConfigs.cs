using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TRACKR.Models
{
    public class UsuarioConfigs
    {
        //tabela com as configurações de cada usuario
        public int ID { get; set; }
        public Usuario usuario { get; set; }
        public string PrimeiroDiaDaSemana { get; set; }
        public Decimal AumentarDiminuirMinutos { get; set; }
    }
}
