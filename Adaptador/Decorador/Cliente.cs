using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class Client
    {
        public void Ejecutar(Componente component,entCuentaPagar entCxP)
        {
            Console.WriteLine(component.Ejecutar(entCxP));
        }
    }
}
