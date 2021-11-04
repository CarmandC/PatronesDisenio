using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio
{
    public class Ordenes
    {
        public List<Datos.DTO.Orden> ListadoEnviadas()
        {
            List<Datos.DTO.Orden> lista = new List<Datos.DTO.Orden>();

            lista.Add(new Datos.DTO.Orden("100328102100001", "A",""));
            lista.Add(new Datos.DTO.Orden("100328102100002", "R", ""));
            lista.Add(new Datos.DTO.Orden("100328102100003", "A", ""));
            lista.Add(new Datos.DTO.Orden("100328102100004", "A", ""));
            lista.Add(new Datos.DTO.Orden("100328102100005", "A", ""));
            lista.Add(new Datos.DTO.Orden("100328102100006", "R", ""));
            lista.Add(new Datos.DTO.Orden("100328102100007", "A", ""));
            lista.Add(new Datos.DTO.Orden("100328102100008", "A", ""));


            return lista;
        }

        public List<Datos.DTO.Orden> ListadoRecibidas()
        {
            List<Datos.DTO.Orden> lista = new List<Datos.DTO.Orden>();

            lista.Add(new Datos.DTO.Orden("100328102110001", "T", ""));
            lista.Add(new Datos.DTO.Orden("100328102110002", "T", ""));
            lista.Add(new Datos.DTO.Orden("100328102140003", "T", ""));
            lista.Add(new Datos.DTO.Orden("100328102110004", "T", ""));
            lista.Add(new Datos.DTO.Orden("100328102110005", "T", ""));
            lista.Add(new Datos.DTO.Orden("100328102110006", "T", ""));
            lista.Add(new Datos.DTO.Orden("100328102110007", "T", ""));
            lista.Add(new Datos.DTO.Orden("100328102110008", "T", ""));


            return lista;
        }

    }
}
