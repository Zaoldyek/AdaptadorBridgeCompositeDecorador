using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Envios terrestre = new Terrestre();
            Envios aereo = new Aereo();
            Envios tren = new Tren();
            Envios barco = new Barco();

            Empresas fedex = new FEDEXSerice(barco);
            Empresas dhl = new DHL(aereo);
            Empresas dhlBarco = new DHL(barco);
            Empresas estafeta = new Estafeta(tren);

            fedex.RecogerPedido();
            fedex.EnviarPedido();
            fedex.EntregarPedido();

            Console.WriteLine("\n");

            dhl.RecogerPedido();
            dhl.EnviarPedido();
            dhl.EntregarPedido();

            Console.WriteLine("\n");

            dhlBarco.RecogerPedido();
            dhlBarco.EnviarPedido();
            dhlBarco.EntregarPedido();

            Console.WriteLine("\n");

            estafeta.RecogerPedido();
            estafeta.EnviarPedido();
            estafeta.EntregarPedido();


            Console.ReadLine();
        }
    }

    public interface Envios
    {
        void CargarPedido();
        void ProcesarEnvio();
        void ProcesarEntrega();
    }

    public class Terrestre : Envios
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
    public class Aereo : Envios
    {
        public void CargarPedido()
        {
            Console.WriteLine("Se cargo el envio Aereo");
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
    public class Tren : Envios
    {
        public void CargarPedido()
        {
            Console.WriteLine("Se cargo el envio por Tren");
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

    public class Barco : Envios
    {
        public void CargarPedido()
        {
            Console.WriteLine("Se cargo el envio por Barco");
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


    public interface Empresas
    {
        Envios envios { get; set; }
        
        void RecogerPedido();
        void EnviarPedido();
        void EntregarPedido();

    }

    public class FEDEXSerice : Empresas
    {
        public Envios envios { get; set; }

        public FEDEXSerice(Envios _envio) {
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

    public class DHL : Empresas
    {
        public Envios envios { get; set; }

        public DHL(Envios _envio)
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
    public class Estafeta : Empresas
    {
        public Envios envios { get; set; }

        public Estafeta(Envios _envio)
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
