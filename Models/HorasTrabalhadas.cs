using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TRACKR.Models
{
    public class HorasTrabalhadas
    {
        public int ID { get; set; }
        public Projeto Projeto { get; set; }
        public Tarefa Tarefa { get; set; }
        public DateTime dataDeInicio { get; set; }
        public DateTime dataDeFim { get; set; }
        public int TimeZoneInfoID { get; set; }
    }
}
