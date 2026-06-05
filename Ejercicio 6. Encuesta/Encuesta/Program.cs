using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        static int MostrarPantallaSolicitarOpcionMenu(int opinion)
        {
            Console.WriteLine("Ingrese una opcion: ");
            Console.WriteLine("1. Registrar Opinion.");
            Console.WriteLine("2. Resultados de la encuesta:");
            Console.WriteLine("3. Salir.");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaRegistrarEncuesta() 
        {

            Console.WriteLine("Ingrese una opinion: ");
            Console.WriteLine("0.Positivo.\n1.Negativo.\n2.Indeciso.");
            int opinion = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarOpinion(opinion);
            Console.Clear();
        }
        static void MostrarPantallaProcesarMostrarResultadosEncuesta()
        {
            Console.Clear();
            servicio.ProcesarEncuesta();
            Console.WriteLine("Resultados de la encuesta: ");
            Console.WriteLine($"Positivos: {servicio.PorcentajePositivos}%");
            Console.WriteLine($"Negativos: {servicio.PorcentajeNegativos}%");
            Console.WriteLine($"Indecisos: {servicio.PorcentajeIndecisos}%");
        }
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu(0);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        MostrarPantallaRegistrarEncuesta();
                        break;
                    case 2:
                        MostrarPantallaProcesarMostrarResultadosEncuesta();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa..");
                        break;
                    default: Console.WriteLine("opcion invalida. Por favor ingrese un numero del 1 - 3"); break;
                }
            } while (opcion != 3);
        }
    }
}
