using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Caja : lPedido
    {
        List<lPedido> lstCaja { get; set; }
        string cNombre { get; set; }

        public Caja(string _cNombre)
        {
            lstCaja = new List<lPedido>();
            cNombre = _cNombre;
        }

        public void addHijo(lPedido hijo)
        {
            lstCaja.Add(hijo);
        }
        public decimal obtenerTotal()
        {
            decimal total = 0;
            foreach (lPedido lstC in lstCaja)
            {
                total = total + lstC.obtenerTotal();
            }
            Console.WriteLine(cNombre + " Tiene un total de " + total);
            return total;
        }
    }
}
