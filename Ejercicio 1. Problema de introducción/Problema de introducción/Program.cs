using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_de_introducción
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        static int MostrarPantallaSolicitarMenu()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Procesar un solo numero");
            Console.WriteLine("2. Procesar varios numeros");
            Console.WriteLine("3. Mostrar maximo y minimo.");
            Console.WriteLine("4. Mostrar promedio.");
            Console.WriteLine("5. Mostrar cantidad de numeros ingresados.");
            Console.WriteLine("6. Reiniciar variables.");
            Console.WriteLine("7. Salir.");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void InicializarVariables()
        {
            Console.Clear();
            servicio = new Servicio();
            Console.WriteLine("Variables reiniciadas.");
        }
        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarValor(numero);
        }
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de numeros a procesar:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                MostrarPantallaSolicitarNumero();
            }

        }
        static void MostrarPantallaMaximo()
        {
            Console.Clear();
            Console.WriteLine("El numero maximo es: " + servicio.Maximo);
        }
        static void MostrarPantallaMinimo()
        {
            
            Console.WriteLine("El numero minimo es: " + servicio.Minimo);
        }
        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();
            Console.WriteLine("El promedio es: " + servicio.CalcularPromedio());
        }
        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            Console.WriteLine("Cantidad de numeros ingresados: " + servicio.Contador);
        }
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                opcion = MostrarPantallaSolicitarMenu();
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantallaMaximo();
                        MostrarPantallaMinimo();
                        break;
                    case 4:
                        MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        InicializarVariables();
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
                Console.WriteLine();
            } while (opcion != 7);


        }
    }
}
