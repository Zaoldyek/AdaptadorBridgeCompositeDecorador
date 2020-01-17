using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            entidadPrecio entPrecio = new entidadPrecio();
            Caja caja0 = new Caja("UA X");
            Caja caja1 = new Caja("1");
            Caja caja11 = new Caja("1.1");
            Caja caja111 = new Caja("1.1.1");
            Caja caja2 = new Caja("2");
            Caja caja21 = new Caja("2.1");
            Caja caja211 = new Caja("2.1.1");
            Caja caja3 = new Caja("3");
            Caja caja31 = new Caja("3.1");
            Caja caja4 = new Caja("4");

            entPrecio = new entidadPrecio() { iId = 1, precio1 = 10, precio2 = 20, precio3 = 30 };
            Producto producto1 = new Producto(entPrecio,"1.1.1.1");
            caja111.addHijo(producto1);
            caja11.addHijo(caja111);
            caja1.addHijo(caja11);
            caja0.addHijo(caja1);

            entPrecio = new entidadPrecio() { iId = 2, precio1 = 7, precio2 = 8, precio3 = 9 };
            Producto producto2 = new Producto(entPrecio, "2.1.1.1");
            caja211.addHijo(producto2);
            caja21.addHijo(caja211);
            caja2.addHijo(caja21);
            caja0.addHijo(caja2);

            entPrecio = new entidadPrecio() { iId = 3, precio1 = 2, precio2 = 3, precio3 = 4 };
            Producto producto3 = new Producto(entPrecio, "3.1.1");
            caja31.addHijo(producto3);
            caja3.addHijo(caja31);
            caja0.addHijo(caja3);

            entPrecio = new entidadPrecio() { iId = 4, precio1 = 1, precio2 = 1, precio3 = 1 };
            Producto producto4 = new Producto(entPrecio, "4.1");
            caja4.addHijo(producto4);
            caja0.addHijo(caja4);

            caja0.obtenerTotal();

            Console.ReadLine();
        }
    }

}
