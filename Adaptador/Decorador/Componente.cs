using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public abstract class Componente
    {
        public abstract string Ejecutar(entCuentaPagar entCxP);
    }
}
