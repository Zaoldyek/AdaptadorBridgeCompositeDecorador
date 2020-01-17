using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class GuardarCxP : Componente
    {
        public override string Ejecutar(entCuentaPagar entCxP)
        {
            return "RESULTADO: Se guardo la Cuenta por pagar: CuentaPagar=" +entCxP.iIdCuentaPagar+", Importe= "+ entCxP.iImporte +" y Naturaleza="+entCxP.iNaturaleza;
        } 
    }
}
