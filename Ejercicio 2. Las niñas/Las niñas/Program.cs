using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_niñas
{
    internal class Program
    {
        static Servicio Servicio = new Servicio();

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Registrar monto a repartir");
            Console.WriteLine("2. Registrar edades de las niñas");
            Console.WriteLine("3. Calcular montos y porcentajes");
            Console.WriteLine("4. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }   
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a repartir:");
            double monto = Convert.ToDouble(Console.ReadLine());
            Servicio.RegistrarMontoARepartir(monto);

        }
        static void MostrarPantallaRegistrarEdadesDeLasNiñas()
        {
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese la edad de la niña {i}:");
                int edad = Convert.ToInt32(Console.ReadLine());
                if (edad < 0)
                {
                    Console.WriteLine("La edad no puede ser negativa. Intente nuevamente.");
                    i--; // Decrementar para volver a solicitar la edad de la misma niña
                    continue;
                }
                Servicio.RegistrarEdad(edad, i);
            }
        }
        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            Console.Clear();
            Servicio.CalcularMontosYPorcentajesARepartir();
            if (Servicio.Monto <= 0)
            {
                Console.WriteLine("No se han registrado las edades de las niñas. Por favor, registre las edades antes de calcular los montos y porcentajes.");
                return;
            }
            Console.WriteLine($"Niña 0: Monto = $ {Servicio.Monto0:F2} / Porcentaje = {Servicio.Porcentaje0:F2}%");
            Console.WriteLine($"Niña 1: Monto = $ {Servicio.Monto1:F2} / Porcentaje = {Servicio.Porcentaje1:F2}%");
            Console.WriteLine($"Niña 2: Monto = $ {Servicio.Monto2:F2} / Porcentaje = {Servicio.Porcentaje2:F2}%");
            Console.WriteLine($"Niña 3: Monto = $ {Servicio.Monto3:F2} / Porcentaje = {Servicio.Porcentaje3:F2}%");
        }

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        MostrarPantallaRegistrarEdadesDeLasNiñas();
                        break;
                    case 3:
                        MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
                Console.WriteLine();
            } while (opcion != 4);
            
            Console.WriteLine("Programa finalizado. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
