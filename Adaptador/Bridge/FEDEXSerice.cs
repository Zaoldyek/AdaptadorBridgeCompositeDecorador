using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class FEDEXSerice : lEmpresas
    {
        public lEnvios envios { get; set; }

        public FEDEXSerice(lEnvios _envio)
        {
            envios = _envio;
        }

        public void EntregarPedido()
        {
            Console.WriteLine("Fedex esta entregando el paquete");
            envios.ProcesarEntrega();
        }

        public void EnviarPedido()
        {
            Console.WriteLine("Fedex ah enviado el paquete");
            envios.ProcesarEnvio();
        }

        public void RecogerPedido()
        {
            Console.WriteLine("Fedex ah recogido el paquete");
            envios.CargarPedido();
        }
    }
}
