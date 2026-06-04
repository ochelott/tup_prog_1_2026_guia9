using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        static string DeterminarGanador()
        {
            Console.Clear();
            Console.WriteLine("El ganador es: " + servicio.DeterminarGanador());
            return servicio.ToString();
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Registrar los nombres de los jugadores.");
            Console.WriteLine("2. Registrar los resultados de cada set de los jugadores.");
            Console.WriteLine("3. Mostrar el ganador.");
            Console.WriteLine("4. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
            
        }
        static void MostrarPantallaSolicitarNombreJugadores() 
        {

            Console.WriteLine("Jugador 1: ");
            string nombre1 = Console.ReadLine();

            Console.WriteLine("Jugador 2: ");
            string nombre2 = Console.ReadLine();

            servicio.RegistrarJugadores(nombre1, nombre2);
            Console.Clear();
        }
        static void MostrarPantallaSolicitarResultadoSet()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Set {i} jugador 1:");
                int resultado1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Set {i} jugador 2:");
                int resultado2 = Convert.ToInt32(Console.ReadLine());

                servicio.RegistrarResultadoSet(resultado1, resultado2);
            }
            Console.Clear();
        }
        static void MostrarPantallaGanador()
        {
            Console.Clear();
            Console.WriteLine("El ganador es: " + servicio.DeterminarGanador());
        }
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarNombreJugadores();
                        break;
                    case 2:
                        MostrarPantallaSolicitarResultadoSet();
                        break;
                    case 3:
                        MostrarPantallaGanador();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                        break;
                }
                
                Console.WriteLine();
                
            } while (opcion != 4);
                
            Console.WriteLine("Programa finalizado. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
