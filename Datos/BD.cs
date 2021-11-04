using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Datos
{
    public class ConnSingleton
    {

        private static String constr = null; //holds tnsnames.ora statemnt

        private static ConnSingleton dbInstance;
        private OracleConnection conn;

        private ConnSingleton()
        {
        }

        public static ConnSingleton getDbInstance()
        {
            if (dbInstance == null)
            {

                dbInstance = new ConnSingleton();
            }
            return dbInstance;
        }

        /// <summary>
        /// this returns an oracle connection created using the connection string
        /// </summary>
        /// <returns>oracle connection</returns>
        public OracleConnection GetDBConnection()
        {
            try
            {
                createConnectionstring();
                conn = new OracleConnection(constr);
                conn.Open();
                Console.WriteLine("Connected");
            }
            catch (OracleException e)
            {
                Console.WriteLine("Not connected: " +e.ToString());
                Console.ReadLine();
            }

            return conn;
        }

        /// <summary>
        /// this closes the created database connection
        /// </summary>
        public void closeDBConnection()
        {
            try
            {
                conn.Close();
                Console.WriteLine("Connection closed");
            }
            catch (OracleException e)
            {
                Console.WriteLine("Connection closed failed: " +e.ToString());

            }
            finally
            {
                Console.WriteLine("End..");

            }

        }

        /// <summary>
        /// Read the configurations.xml in order to create the connection string
        /// </summary>
        public static void createConnectionstring()
        {

            try
            {

                
                constr = "DATA SOURCE=172.16.1.23/BGDB;PASSWORD=SRV123;USER ID=AUTOSRV;Min Pool Size=10;Connection Lifetime=100000;Connection Timeout=60;Incr Pool Size=5; Decr Pool Size=2;Max Pool Size=150;";
                Console.WriteLine("ConstrVariable created ");

            }
            catch (Exception ConstrError)
            {
                Console.WriteLine(ConstrError.Message);
            }

        }
    }
}



