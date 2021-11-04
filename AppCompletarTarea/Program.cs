using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCompletarTarea
{
    class Program
    {
        static void Main(string[] args)
        {

            Client.ClientCode(new Negocio.ClsDebito());
            Console.Write("\n");
            Console.ReadKey();


            Client.ClientCode(new Negocio.ClsCredito());
            Console.Write("\n");
            Console.ReadKey();


            

        }
    }
}
