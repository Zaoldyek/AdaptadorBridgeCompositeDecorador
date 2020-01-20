using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Estafeta : lEmpresas
    {
        public lEnvios envios { get; set; }

        public Estafeta(lEnvios _envio)
        {
            envios = _envio;
        }

        public void EntregarPedido()
        {
            Console.WriteLine("Estafeta esta entregando el paquete");
            envios.ProcesarEntrega();
        }

        public void EnviarPedido()
        {
            Console.WriteLine("Estafeta ah enviado el paquete");
            envios.ProcesarEnvio();
        }

        public void RecogerPedido()
        {
            Console.WriteLine("Estafeta ah recogido el paquete");
            envios.CargarPedido();
        }
    }
}
