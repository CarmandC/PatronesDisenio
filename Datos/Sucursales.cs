using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Repositorio
{
    public class Sucursales
    {
        public void GetSucursales()
        {
            Datos.ConnSingleton dbInstance=Datos.ConnSingleton.getDbInstance();
            OracleConnection db = dbInstance.GetDBConnection();

            Console.WriteLine("Ejecutando query...");
            Random _random = new Random();

            Thread.Sleep(_random.Next(5000, 15000));

            dbInstance.closeDBConnection();
            string cadena = "";
        }

        public void GetParametros()
        {

            try
            {
                using (OracleConnection db = new OracleConnection("DATA SOURCE=172.16.1.23/BGDB;PASSWORD=SRV123;USER ID=AUTOSRV;Min Pool Size=10;Connection Lifetime=100000;Connection Timeout=60;Incr Pool Size=5; Decr Pool Size=2;Max Pool Size=150;"))
                {
                    db.Open();
                    OracleCommand comando = new OracleCommand("Select * from eap_aplicaciones", db);
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Ejecutando query...");

                    Random _random = new Random();

                    Thread.Sleep(_random.Next(5000,15000));
                    //throw new Exception("Falla prueba");
                    db.Close();
                    db.Dispose();
                    
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {

            }
            
             

            

            

            string cadena = "";
        }

    }
}
