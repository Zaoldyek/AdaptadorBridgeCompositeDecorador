using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public abstract class Decorador : Componente
    {
        protected Componente componente;

        public Decorador(Componente _componente)
        {
            this.componente = _componente;
        }

        public void SetComponente(Componente _componente)
        {
            this.componente = _componente;
        }

        public override string Ejecutar(entCuentaPagar entCxP)
        {
            if (this.componente != null)
            {
                return this.componente.Ejecutar(entCxP);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
