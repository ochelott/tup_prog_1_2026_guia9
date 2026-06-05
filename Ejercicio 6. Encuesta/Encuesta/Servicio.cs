using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta
{
    internal class Servicio
    {
        private int indecisos = 0;
        private int negativos = 0;
        private int positivos = 0;
        public double PorcentajeIndecisos;
        public double PorcentajeNegativos;
        public double PorcentajePositivos;

        public void RegistrarOpinion (int opinion)
        {
            switch (opinion)
            {
                case 0:
                    positivos++; break;

                case 1:
                    negativos++; break;

                case 2:
                    indecisos++; break;
            }
        }
        public void ProcesarEncuesta()
        {
            if (indecisos > 0 || negativos > 0 || positivos > 0)
            {
                int suma = indecisos + negativos + positivos;
                PorcentajeIndecisos = ((double)indecisos / suma) * 100;
                PorcentajeNegativos = ((double)negativos / suma) * 100;
                PorcentajePositivos = ((double)positivos / suma) * 100;
            }
            else Console.WriteLine("No hubo encuestados..");
        }
    }
}
