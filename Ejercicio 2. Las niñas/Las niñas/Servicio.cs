using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_niñas
{
    internal class Servicio
    {
        public int Edad0;
        public int Edad1;
        public int Edad2;
        public int Edad3;

        public double Monto;
        public double Porcentaje0;
        public double Porcentaje1;
        public double Porcentaje2;
        public double Porcentaje3;
        public double Monto0;
        public double Monto1;
        public double Monto2;
        public double Monto3;
    
    public void RegistrarMontoARepartir(double monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("El monto debe ser un número positivo. Intente nuevamente.");
                return;
            }
            Monto = monto;
        }
        public void RegistrarEdad(int edad, int nroNiña)
        {
            switch (nroNiña)
            {
                case 0:
                    Edad0 = edad;
                    break;
                case 1:
                    Edad1 = edad;
                    break;
                case 2:
                    Edad2 = edad;
                    break;
                case 3:
                    Edad3 = edad;
                    break;
            }
        }
        public void CalcularMontosYPorcentajesARepartir()
        {
            int suma = Edad0 + Edad1 + Edad2 + Edad3;
            if (suma > 0)
            {
                Porcentaje0 = ((double)Edad0 / suma) * 100;
                Porcentaje1 = ((double)Edad1 / suma) * 100;
                Porcentaje2 = ((double)Edad2 / suma) * 100;
                Porcentaje3 = ((double)Edad3 / suma) * 100;
                Monto0 = (Porcentaje0 * Monto) / 100;
                Monto1 = (Porcentaje1 * Monto) / 100;
                Monto2 = (Porcentaje2 * Monto) / 100;
                Monto3 = (Porcentaje3 * Monto) / 100;
            }
        }
    }
}