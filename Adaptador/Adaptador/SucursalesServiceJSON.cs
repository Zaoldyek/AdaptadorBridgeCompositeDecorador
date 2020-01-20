using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador
{
    public class SucursalesServiceJSON : lBuscarSucursales
    {
        public List<Sucursales> BuscarSucursales()
        {

            Adapatador adaptador = new Adapatador();
            string cJSON = "";
            List<Sucursales> lstSucursales = new List<Sucursales>();
            cJSON = adaptador.BuscarSucursalesJSON();
            lstSucursales = JsonConvert.DeserializeObject<lstSucursales>(cJSON).Sucursales;


            return lstSucursales;
        }
    }
}
