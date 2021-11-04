using Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClsDebito : ClsContabilidad
    {
        List<Datos.DTO.Orden> Ordenes;

        public ClsDebito()
        {
            registro = new RegistroOrdenes();
            resumen= new RegistroOrdenes();
        }
        protected override void Listado()
        {
            //obtener el listado de pendientes
            Console.WriteLine("Obtener listado pendientes Debito...");
            Datos.Repositorio.Ordenes ordenes = new Datos.Repositorio.Ordenes();
            Ordenes = ordenes.ListadoEnviadas();

            foreach (Orden item in Ordenes)
            {
                if (item.Estado == "A")
                    registro.InsertarOrden(item.NroOrden,item.Estado, "");
                else
                    registro.InsertarOrden(item.NroOrden, item.Estado, "");
            }
        }

        protected override void Contabilidad(Orden orden)
        {
            //Console.WriteLine("Procesar Debito...");
            //Repositorio.Sucursales sucursales = new Repositorio.Sucursales();
            //sucursales.GetSucursales();
            //foreach (Orden item in Ordenes)
            //{
            //    if (item.Estado == "A")
            //        registro.InsertarOrden(item.NroOrden, "APROBADO CONTABLEMENTE");
            //    else
            //        registro.InsertarOrden(item.NroOrden, "Orden Rechazada");
            //}

            Console.WriteLine($"Se procede a contabilizar la orden {orden.NroOrden}");

        }

        protected override Boolean Analizar(Orden orden)
        {



            Console.WriteLine($"Analizando la orden {orden.NroOrden}");
            if (orden.Estado == "A")
            {
                resumen.InsertarOrden(orden.NroOrden, orden.Estado, "Orden Aprobada");
                return true;
            }
                    
            else
            {
                //resumen.InsertarOrden(orden.NroOrden, orden.Estado, "Orden Rechazada");
                Console.WriteLine($"Orden Nro. {orden.NroOrden} ha sido rechazada...");
                return false;
            }
                    
            


        }

        protected override void Comprobante(Orden orden)
        {
            Console.WriteLine($"Se procede a generar el comprobante para la orden {orden.NroOrden}");
        }
    }
}
