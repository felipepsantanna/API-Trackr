using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TRACKR.Models
{
    public class ErrorMessage<T>
    {
        public T Dados { get; set; }
        public string Message { get; set; }
        public bool status { get; set; }
    }
}
