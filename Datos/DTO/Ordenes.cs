using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    public class Orden
    {
        public string NroOrden { get; set; }
        public string Estado { set; get; }
        public string Glosa { set; get; }

        public Orden(string nroOrden, string estado, string glosa)
        {
            this.NroOrden = nroOrden;
            this.Estado = estado;
            this.Glosa = glosa;
        }


    }
}
