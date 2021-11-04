using Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClsCredito : ClsContabilidad
    {
        
        List<Datos.DTO.Orden> Ordenes;

        public ClsCredito()
        {
            registro = new RegistroOrdenes();
        }
        protected override void Listado()
        {
            //Obtener listado de pendientes para credito
            Console.WriteLine("Obtener listado pendientes Crebito...");
            Datos.Repositorio.Ordenes ordenes = new Datos.Repositorio.Ordenes();
            Ordenes = ordenes.ListadoRecibidas();      

        }

        protected override void Contabilidad(Orden orden)
        {
            //Console.WriteLine("Procesar Credito...");
            //Repositorio.Sucursales sucursales = new Repositorio.Sucursales();
            //sucursales.GetParametros();

            Console.WriteLine($"Se procede a contabilizar la orden {orden.NroOrden}");


        }

        protected override Boolean Analizar(Orden orden)
        {

            Console.WriteLine($"Se procede a recepcionar la orden {orden.NroOrden}");
            registro.InsertarOrden(orden.NroOrden,orden.Estado, "SOLICITUD APROBADA!!!!");
            return true;

            
        }

        protected override void Comprobante(Orden orden)
        {
            Console.WriteLine($"Se procede a generar el comprobante para la orden {orden.NroOrden}");
        }


    }
}
