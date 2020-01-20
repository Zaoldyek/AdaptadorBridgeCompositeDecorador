using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador
{
    public class Adapatador : lBuscarSucursalesJSON
    {
        public string BuscarSucursalesJSON()
        {
            string json = "{'Sucursales':[";

            for (int i = 1; i <= 10; i++)
            {
                json = json + "{'iIdSucursal':" + i + ",'cSucursal':'Sucursal" + i + "','iTotal':" + (100 + i) + "}";
                if (i != 10)
                    json = json + ",";
            }
            json = json + "]}";
            return json;
        }
    }

}
