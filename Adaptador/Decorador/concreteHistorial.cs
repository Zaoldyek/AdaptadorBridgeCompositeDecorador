using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class ConcreteHistorial : Decorador
    {
        public ConcreteHistorial(Componente comp) : base(comp)
        {
        }

        public override string Ejecutar(entCuentaPagar entCxP)
        {
            return $"Se guardo en el historial({base.Ejecutar(entCxP)})";
        }
    }
}
