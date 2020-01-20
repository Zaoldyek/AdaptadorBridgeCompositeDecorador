using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador
{
    class Program
    {
        static void Main(string[] args)
        {
            SucursalesServiceJSON sucursalesServiceJSON = new SucursalesServiceJSON();
            SucursalesService sucursalesService = new SucursalesService();
            List<Sucursales> lstSucursales = new List<Sucursales>();

            lstSucursales = sucursalesService.BuscarSucursales();
            Console.WriteLine("#ID##########SUCURSAL#########VENTA");
            foreach (Sucursales suc in lstSucursales)
            {
                Console.WriteLine($"{suc.iIdSucursal}###########{suc.cSucursal}#########{suc.iTotal}");
            }

            Console.WriteLine("\n\n");

            lstSucursales = sucursalesServiceJSON.BuscarSucursales();
            Console.WriteLine("#ID##########SUCURSAL#########VENTA");
            foreach(Sucursales suc in lstSucursales) { 
                Console.WriteLine($"{suc.iIdSucursal}###########{suc.cSucursal}#########{suc.iTotal}");
            }
            Console.ReadLine();
        }

    }
}
