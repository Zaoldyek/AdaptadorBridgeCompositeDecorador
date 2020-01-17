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

    public interface BuscarSucursales
    {
        List<Sucursales> BuscarSucursales();
    }

    public class Sucursales 
    {
        public int iIdSucursal { get; set; }

        public string cSucursal { get; set; }

        public int iTotal { get; set; }
    }

    public class lstSucursales
    {
        public List<Sucursales> Sucursales { get; set; }
    }

    public class SucursalesService : BuscarSucursales
    {
        public List<Sucursales> BuscarSucursales()
        {
            List<Sucursales> lstSucursales = new List<Sucursales>();

            for (int i=1;i<=10;i++) {
                lstSucursales.Add(
                    new Sucursales() {
                        iIdSucursal=i,
                        cSucursal="Sucursal"+i,
                        iTotal=100+i
                    }
                    );
            }


            return lstSucursales;
        }
    }

    public class SucursalesServiceJSON : BuscarSucursales
    {
        public List<Sucursales> BuscarSucursales() {

            Adapatador adaptador = new Adapatador();
            string cJSON = "";
            List<Sucursales> lstSucursales = new List<Sucursales>();
            cJSON=adaptador.BuscarSucursalesJSON();
            lstSucursales = JsonConvert.DeserializeObject<lstSucursales>(cJSON).Sucursales;


            return lstSucursales;
        }
    }

    public class Adapatador : BuscarSucursalesJSON
    {
        public string BuscarSucursalesJSON()
        {
            string json = "{'Sucursales':[";

            for (int i = 1; i <= 10; i++) {
                json = json + "{'iIdSucursal':"+ i +",'cSucursal':'Sucursal" + i + "','iTotal':"+(100+i)+"}";
                if (i != 10)
                    json = json + ",";
            }
            json = json + "]}";
            return json;
        }
    }
  

    public interface BuscarSucursalesJSON
    {
        string BuscarSucursalesJSON();
    }
}
