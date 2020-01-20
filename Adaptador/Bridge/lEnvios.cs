using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface lEnvios
    {
        void CargarPedido();
        void ProcesarEnvio();
        void ProcesarEntrega();
    }
}
