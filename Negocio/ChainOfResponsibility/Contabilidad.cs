using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ChainOfResponsibility
{
    public class Contabilidad : AbstractHandler
    {
        
            public override object Handle(Boolean request)
            {
                if (request == false)
                {
                    return $"Rollback!!";
                }
                else
                {
                    
                    return base.Handle(request);
                }
            }
        
    }
}
