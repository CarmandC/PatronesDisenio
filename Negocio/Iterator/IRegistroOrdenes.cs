using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IRegistroOrdenes
    {
        void InsertarOrden(string nroOrden, string estado, string glosa);
        
        IIteratorOrden ObtenerIterator();
    }
}
