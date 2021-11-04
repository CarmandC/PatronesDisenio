using Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IIteratorOrden
    {
        void Primero();
        Orden Actual();
        Orden Siguiente();
        bool QuedanElementos();
    }
}
