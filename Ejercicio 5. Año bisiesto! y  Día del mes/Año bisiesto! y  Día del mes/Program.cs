using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Año_bisiesto__y__Día_del_mes
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        static int SolicitarPantallaOpcionMenu()
        {
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1. Determinar los días del mes. ");
            Console.WriteLine("2. Verificar si un año es bisiesto. ");
            Console.WriteLine("3. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            Console.Clear();
            
            Console.WriteLine("Ingrese el mes (1-12): ");
            int mes = Convert.ToInt32(Console.ReadLine());
            if (mes >= 1 && mes <= 12)
            {
                Console.WriteLine("Ingrese el año: ");
                int año = Convert.ToInt32(Console.ReadLine());
                int dias = servicio.DeterminarLosDiasDelMes(mes, año);
                Console.WriteLine($"El mes {mes} del año {año} tiene {dias} días.");
            } else Console.WriteLine("Mes no válido. Por favor, ingrese un número entre 1 y 12.");

        }
        static void MostrarPantallaVerificarSiElAñoEsBisiesto()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el año: ");
            int año = Convert.ToInt32(Console.ReadLine());
            if (servicio.EsBisiesto(año))
            {
                Console.WriteLine($"El año {año} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {año} no es bisiesto.");
            }
            
        }

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                opcion = SolicitarPantallaOpcionMenu();
                Console.Clear();
                
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarMesAñoYDeterminarDias();
                        break;
                    case 2:
                        MostrarPantallaVerificarSiElAñoEsBisiesto();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                        break;
                }
                
                Console.WriteLine();

            } while (opcion != 3);

             Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey(); 

        }
    }
}
