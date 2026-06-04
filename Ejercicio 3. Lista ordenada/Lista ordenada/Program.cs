using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_ordenada
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("Ingrese una opción:");
            Console.WriteLine("1. Registrar las notas de los 3 alumnos");
            Console.WriteLine("2. Mostrar lista ordenada");
            Console.WriteLine("3. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        static void MostrarPantallaSolicitarAlumnos()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el número de libreta del alumno:");
                int numeroLibreta = Convert.ToInt32(Console.ReadLine());
                servicio.RegistrarNombreYnumeroLibreta(nombre, numeroLibreta);
                Console.Clear();
            }
        }
        static void MostrarPantallaMostrarListaOrdenada()
        {
            Console.Clear();
            if (servicio.NumeroLibreta1 < servicio.NumeroLibreta0 && servicio.NumeroLibreta1 < servicio.NumeroLibreta2)
            {
                Console.WriteLine(servicio.Nombre1 + " - " + servicio.NumeroLibreta1);
                if (servicio.NumeroLibreta0 < servicio.NumeroLibreta2)
                {
                    Console.WriteLine(servicio.Nombre0 + " - " + servicio.NumeroLibreta0);
                    Console.WriteLine(servicio.Nombre2 + " - " + servicio.NumeroLibreta2);
                }
                else
                {
                    Console.WriteLine(servicio.Nombre2 + " - " + servicio.NumeroLibreta2);
                    Console.WriteLine(servicio.Nombre0 + " - " + servicio.NumeroLibreta0);
                }
            }
            else if (servicio.NumeroLibreta0 < servicio.NumeroLibreta1 && servicio.NumeroLibreta0 < servicio.NumeroLibreta2)
            {
                Console.WriteLine(servicio.Nombre0 + " - " + servicio.NumeroLibreta0);
                if (servicio.NumeroLibreta1 < servicio.NumeroLibreta2)
                {
                    Console.WriteLine(servicio.Nombre1 + " - " + servicio.NumeroLibreta1);
                    Console.WriteLine(servicio.Nombre2 + " - " + servicio.NumeroLibreta2);
                }
                else
                {
                    Console.WriteLine(servicio.Nombre2 + " - " + servicio.NumeroLibreta2);
                    Console.WriteLine(servicio.Nombre1 + " - " + servicio.NumeroLibreta1);
                }
            }
            else
            {
                Console.WriteLine(servicio.Nombre2 + " - " + servicio.NumeroLibreta2);
                if (servicio.NumeroLibreta0 < servicio.NumeroLibreta1)
                {
                    Console.WriteLine(servicio.Nombre0 + " - " + servicio.NumeroLibreta0);
                    Console.WriteLine(servicio.Nombre1 + " - " + servicio.NumeroLibreta1);
                }
                else
                {
                    Console.WriteLine(servicio.Nombre1 + " - " + servicio.NumeroLibreta1);
                    Console.WriteLine(servicio.Nombre0 + " - " + servicio.NumeroLibreta0);
                }
            }
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
                        MostrarPantallaSolicitarAlumnos();
                        break;
                    case 2:
                        MostrarPantallaMostrarListaOrdenada();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida.");
                        break;
                }
            
                Console.WriteLine();
           
            } while (opcion != 3);

            Console.WriteLine("Programa finalizado. Presione cualquier tecla para salir.");   
            Console.ReadKey();
        }
    }
}
