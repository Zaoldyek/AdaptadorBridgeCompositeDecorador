using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class DHL : lEmpresas
    {
        public lEnvios envios { get; set; }

        public DHL(lEnvios _envio)
        {
            envios = _envio;
        }

        public void EntregarPedido()
        {
            Console.WriteLine("DHL esta entregando el paquete");
            envios.ProcesarEntrega();
        }

        public void EnviarPedido()
        {
            Console.WriteLine("DHL ah enviado el paquete");
            envios.ProcesarEnvio();
        }

        public void RecogerPedido()
        {
            Console.WriteLine("DHL ah recogido el paquete");
            envios.CargarPedido();
        }
    }
}
