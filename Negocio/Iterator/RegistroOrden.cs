using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DTO;

namespace Negocio
{
    class RegistroOrdenes : IRegistroOrdenes
    {
        private ArrayList listaOrdenes;
        public RegistroOrdenes()
        {
            this.listaOrdenes = new ArrayList();
        }

        public void InsertarOrden(string nroOrden, string estado, string glosa)
        {
            Orden v = new Datos.DTO.Orden( nroOrden, estado,glosa);
            listaOrdenes.Add(v);
        }

        public Orden MostrarInformacionOrden(int indice)
        {
            return (Orden)listaOrdenes[indice];
        }

        public IIteratorOrden ObtenerIterator()
        {
            return new IteratorOrden(listaOrdenes);
        }
    }
}
