using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Producto : lPedido
    {
        entidadPrecio EntidadPrecio { get; set; }
        string cNombre { get; set; }
        public Producto(entidadPrecio entPrecio, string _cNombre)
        {
            EntidadPrecio = new entidadPrecio()
            {
                iId = entPrecio.iId,
                precio1 = entPrecio.precio1,
                precio2 = entPrecio.precio2,
                precio3 = entPrecio.precio3
            };
            cNombre = _cNombre;
        }
        public decimal obtenerTotal()
        {
           
            return EntidadPrecio.precio1 + EntidadPrecio.precio2 + EntidadPrecio.precio3;
        }
    }
}
