using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DTO;

namespace Negocio
{
    public class IteratorOrden: IIteratorOrden
    {
        private ArrayList ordenes;

        // Almacenaremos el índice en el que se encuentra el iterador
        private int posicionActual = -1;

        // El constructor inyectará el ArrayList en el objeto
        public IteratorOrden(ArrayList listado)
        {
            this.ordenes = listado;
        }

        public Orden Actual()
        {
            if ((this.ordenes == null) || (this.ordenes.Count == 0) || (posicionActual > this.ordenes.Count - 1) || (this.posicionActual < 0))
                return null;            
            else
                return (Orden)this.ordenes[posicionActual];
        }

        public void Primero()
        {
            this.posicionActual = -1;
        }

        public bool QuedanElementos()
        {
            return (posicionActual + 1 <= this.ordenes.Count - 1);
        }

        public Orden Siguiente()
        {
            if ((this.ordenes == null) || (this.ordenes.Count == 0) || (posicionActual + 1 > this.ordenes.Count - 1))
                return null;            
            else
                return (Orden)this.ordenes[++posicionActual];
        }
    }
}
