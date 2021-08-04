using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSVentas.Model.Response
{
    public class Respuesta
    {
        public int exito { get; set; }
        public string mensaje{get;set;}
        public object data { get; set; }
        public Respuesta()
        {
            exito = 0;
        }
    }
}
