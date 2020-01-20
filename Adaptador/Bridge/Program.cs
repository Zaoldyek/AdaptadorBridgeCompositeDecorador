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
            lEnvios terrestre = new Terrestre();
            lEnvios aereo = new Aereo();
            lEnvios tren = new Tren();
            lEnvios barco = new Barco();

            lEmpresas fedex = new FEDEXSerice(barco);
            lEmpresas dhl = new DHL(aereo);
            lEmpresas dhlBarco = new DHL(barco);
            lEmpresas estafeta = new Estafeta(tren);

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

}
