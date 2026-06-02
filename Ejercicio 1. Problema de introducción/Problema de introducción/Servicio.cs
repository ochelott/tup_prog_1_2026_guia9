using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_de_introducción
{
    internal class Servicio
    {
        private int acumulador;
        public int Contador;
        public int Maximo;
        public int Minimo;

        public Servicio()
        {
            acumulador = 0;
            Contador = 0;
            Maximo = int.MinValue;
            Minimo = int.MaxValue;
        }
        public double CalcularPromedio()
        {
            if (Contador == 0)
                return 0;
            return (double)acumulador / Contador;
        }
        public void RegistrarValor(int valor)
        {
            acumulador += valor;
            Contador++;
            if (valor > Maximo)
                Maximo = valor;
            if (valor < Minimo)
                Minimo = valor;
        }
    }
}
