using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos al cliente
            Client cliente = new Client();

            //Instanciamos los decoradores
            ConcreteHistorial decoradorHistorial = null;
            ConcreteEmail decoradorEmail = null;

            //instanciamos el servicio principal
            GuardarCxP guardarCxP = new GuardarCxP();

            //instanciamos la entridad de cuenta por pagar con los valores deceados
            entCuentaPagar entCxP = new entCuentaPagar() { iIdCuentaPagar = 5, iImporte = 100, iNaturaleza = 1 };

            while (true)
            {
                Console.WriteLine("Seleccione una opción: \n 1°) Guardar CxP \n 2°) Guardar Historial y Guardar CxP \n 3°) Enviar Email y Guardar CxP \n 4°) Enviar Correo, Guardar Historia y Guardar CxP");
                string cAccion = Console.ReadLine();
                switch (cAccion)
                {
                    case "1":
                        //Ejecutamos el servicio de guardado sin decoradores
                        Console.WriteLine("1°) Se requiere que guarde una CxP");
                        cliente.Ejecutar(guardarCxP, entCxP);
                        break;
                    case "2":
                        //Ejecutamos el servicio de guardado con el decorador de guardado de historial
                        decoradorHistorial = new ConcreteHistorial(guardarCxP);
                        Console.WriteLine("2°) Se debe guardar un Historial al guardar una CxP");
                        cliente.Ejecutar(decoradorHistorial, entCxP);
                        break;
                    case "3":
                        //Ejecutamos el servicio de guardado con el decorador de enviar correo
                        decoradorEmail = new ConcreteEmail(guardarCxP);
                        Console.WriteLine("3°) Se requiere que cuando se guarde una CXP se envié un correo a un usuario");
                        cliente.Ejecutar(decoradorEmail, entCxP);
                        break;
                    case "4":
                        //Ejecutamos el servicio de guardado con el decorador de guardar historial y este a la vez con un decorador de enviar email
                        decoradorHistorial = new ConcreteHistorial(guardarCxP);
                        decoradorEmail = new ConcreteEmail(decoradorHistorial);
                        Console.WriteLine("4°) Se requiere que cuando se guarde una CXP se guarde un historial, y se envié un correo a un usuario.");
                        cliente.Ejecutar(decoradorEmail, entCxP);

                        break;
                    default:
                        Console.WriteLine("No es una opcion válida");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
