using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador
{
    public class SucursalesService : lBuscarSucursales
    {
        public List<Sucursales> BuscarSucursales()
        {
            List<Sucursales> lstSucursales = new List<Sucursales>();

            for (int i = 1; i <= 10; i++)
            {
                lstSucursales.Add(
                    new Sucursales()
                    {
                        iIdSucursal = i,
                        cSucursal = "Sucursal" + i,
                        iTotal = 100 + i
                    }
                    );
            }


            return lstSucursales;
        }
    }
}
