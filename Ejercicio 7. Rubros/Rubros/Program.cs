using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubros
{
    internal class Program
    {

        static servicio servicio = new servicio();
        static int MostrarPantallaOpcionMenu()
        {
            Console.WriteLine("Ingrese una opcion: ");
            Console.WriteLine("1.Ingresar un resumen de venta");
            Console.WriteLine("2.Mostrar Numero de transaccion registrado con el mayor monto total.");
            Console.WriteLine("3.Mostrar porcentaje de cantidad de ventas por rubro.");
            Console.WriteLine("4.Mostrar recaudacion total.");
            Console.WriteLine("5.Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaRegistrarTransaccion()
        {
            
            Console.WriteLine("Ingrese el numero de transaccion: ");
            int nroTransaccion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el rubro: [1 - 5] ");
            int rubro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el monto:");
            double monto = Convert.ToDouble(Console.ReadLine());
            servicio.EvaluarTransaccionPuntoDeVenta(nroTransaccion, rubro, cantidad, monto);
            Console.Clear();
        }
        static void MostrarPantallaPorcentajeDeCantidadesPorRubro()
        {
            Console.Clear();
            servicio.CalcularPorcentajesCantidadVentasPorRubro();
            Console.WriteLine($"Rubro 1: {servicio.PorcentajeCantidadRubro1:F2} %");
            Console.WriteLine($"Rubro 2: {servicio.PorcentajeCantidadRubro2:F2} %");
            Console.WriteLine($"Rubro 3: {servicio.PorcentajeCantidadRubro3:F2} %");
            Console.WriteLine($"Rubro 4: {servicio.PorcentajeCantidadRubro4:F2} %");
            Console.WriteLine($"Rubro 5: {servicio.PorcentajeCantidadRubro5:F2} %");
        }
        static void MostrarPantallaTransaccionMayorMonto()
        {
            Console.Clear();
            Console.WriteLine("Numero de transaccion: " + servicio.NumeroTransaccionMayor);
            Console.WriteLine("Monto Mayor: " + servicio.MontoTransaccionMayor);
        }
        static void MostrarPantallaMontoRecaudadoTotal()
        {
            Console.Clear();
            Console.WriteLine($"Recaudacion total: ${servicio.RecaudacionTotal:F2}");
        }
        static void Main(string[] args)
        {

            servicio.InicializarVariables();
            int opcion;

            do
            {
                opcion = MostrarPantallaOpcionMenu();
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        MostrarPantallaRegistrarTransaccion();
                        break;
                    case 2:
                        MostrarPantallaTransaccionMayorMonto();
                        break;
                    case 3:
                        MostrarPantallaPorcentajeDeCantidadesPorRubro();
                        break;
                    case 4:
                        MostrarPantallaMontoRecaudadoTotal();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida..");
                        break;
                }
            } while (opcion != 5);
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
