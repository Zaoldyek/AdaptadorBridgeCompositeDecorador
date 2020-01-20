using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Terrestre : lEnvios
    {
        public void CargarPedido()
        {
            Console.WriteLine("Se cargo el envio Terreste");
        }

        public void ProcesarEntrega()
        {
            Console.WriteLine("Se entrego el paquete");
        }

        public void ProcesarEnvio()
        {
            Console.WriteLine("El envio se encuentra en camino");
        }
    }
}
