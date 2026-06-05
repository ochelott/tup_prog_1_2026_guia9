using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubros
{
    internal class servicio
    {
        private int cantidad1;
        private int cantidad2;
        private int cantidad3;
        private int cantidad4;
        private int cantidad5;
        public int NumeroTransaccionMayor;
        public double MontoTransaccionMayor;
        private int contadorDeTransacciones;
        public double PorcentajeCantidadRubro1;
        public double PorcentajeCantidadRubro2;
        public double PorcentajeCantidadRubro3;
        public double PorcentajeCantidadRubro4;
        public double PorcentajeCantidadRubro5;
        public double RecaudacionTotal;

        public void InicializarVariables()
        {
            cantidad1 = 0;
            cantidad2 = 0;
            cantidad3 = 0;
            cantidad4 = 0;
            cantidad5 = 0;
            NumeroTransaccionMayor = 0;
            contadorDeTransacciones = 1;
            MontoTransaccionMayor = 0;
            PorcentajeCantidadRubro1 = 0;
            PorcentajeCantidadRubro2 = 0;
            PorcentajeCantidadRubro3 = 0;
            PorcentajeCantidadRubro4 = 0;
            PorcentajeCantidadRubro5 = 0;
            RecaudacionTotal = 0;
        }
        public void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto)
        {
            switch (rubro)
            {
                case 1:
                    cantidad1 += cantidad;
                    break;
                case 2:
                    cantidad2 += cantidad;
                    break;
                case 3:
                    cantidad3 += cantidad;
                    break;
                case 4:
                    cantidad4 += cantidad;
                    break;
                case 5:
                    cantidad5 += cantidad;
                    break;
                default:
                    Console.WriteLine("Opcion invalida.");
                    Console.WriteLine("Vuelva a ingresar todos los datos nuevamente..");
                    break;
            }
            if (monto > MontoTransaccionMayor)
            {
                MontoTransaccionMayor = monto;
                NumeroTransaccionMayor = nroTransaccion;
            }
            RecaudacionTotal += monto;
            contadorDeTransacciones++;
        }
        public void CalcularPorcentajesCantidadVentasPorRubro()
        {

            int totalCantidad = cantidad1 + cantidad2 + cantidad3 + cantidad4 + cantidad5;
            if (totalCantidad > 0)
            {
                PorcentajeCantidadRubro1 = (double)cantidad1 / totalCantidad * 100;
                PorcentajeCantidadRubro2 = (double)cantidad2 / totalCantidad * 100;
                PorcentajeCantidadRubro3 = (double)cantidad3 / totalCantidad * 100;
                PorcentajeCantidadRubro4 = (double)cantidad4 / totalCantidad * 100;
                PorcentajeCantidadRubro5 = (double)cantidad5 / totalCantidad * 100;
            }
            else Console.WriteLine("No se ingreso ninguna venta..");
        }
    }
}
