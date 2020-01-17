using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class ConcreteEmail : Decorador
    {
        public ConcreteEmail(Componente comp) : base(comp)
        {
        }

        public override string Ejecutar(entCuentaPagar entCxP)
        {
            return $"Se Envio un Correo({base.Ejecutar(entCxP)})";
        }
    }
}
