using Datos.DTO;
using Negocio.ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Negocio
{
    public abstract class ClsContabilidad
    {
        protected IRegistroOrdenes registro;
        protected IRegistroOrdenes resumen;
        private string lStrNombreMetodo;
        public ClsContabilidad()
        {
            lStrNombreMetodo=GetType().Name;
            
        }

        public void Ejecutar()
        {
            this.Iniciar();
            this.Listado();
            this.Analizar();            
            this.ResumenAprobados();
            this.Finalizar();
        }

        

        protected void Iniciar()
        {            
            Console.WriteLine( DateTime.Now.ToString("0:MM/dd/yy H:mm:ss fff") +" - "+ lStrNombreMetodo + "Iniciando la parte contable");
        }

        protected void Finalizar()
        {
            Console.WriteLine(DateTime.Now.ToString("0:MM/dd/yy H:mm:ss fff") + " - " + lStrNombreMetodo + "Finalizando la parte contable");
        }

        protected void Analizar()
        {
            // Obtenemos el iterator
            IIteratorOrden iterador = registro.ObtenerIterator();

            // Mientras queden elementos
            while (iterador.QuedanElementos())
            {
                // Obtenemos el siguiente elemento
                Orden v = iterador.Siguiente();

                if (this.Analizar(v))
                {

                    this.Contabilidad(v);
                    this.Comprobante(v);

                    /*
                    var contabilidad = new Contabilidad();
                    var comprobante = new Comprobante();
                    contabilidad.SetNext(comprobante);

                    var result = contabilidad.Handle(true);
                    */

                }

                Console.Write("\n");

                Random _random = new Random();

                Thread.Sleep(_random.Next(3000, 7000));
            }
        }

        protected void ResumenAprobados()
        {
            // Obtenemos el iterator
            IIteratorOrden iterador = resumen.ObtenerIterator();

            // Mientras queden elementos
            while (iterador.QuedanElementos())
            {
                // Obtenemos el siguiente elemento
                Orden v = iterador.Siguiente();             


                // Mostramos su contenido
                Console.WriteLine("     "+ v.NroOrden + " " + v.Estado );

                Random _random = new Random();

                Thread.Sleep(_random.Next(3000, 7000));
            }
        }

        protected abstract void Listado();

        protected abstract Boolean Analizar(Orden orden);
        protected abstract void Comprobante(Orden orden);
        protected virtual void Contabilidad(Orden orden) { }
        

    }
}
