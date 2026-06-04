using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_ordenada
{
    

    internal class Servicio
    {
        private int Orden;
        public string Nombre0;
        public string Nombre1;
        public string Nombre2;
        public int NumeroLibreta0;
        public int NumeroLibreta1;
        public int NumeroLibreta2;
        
        public void RegistrarNombreYnumeroLibreta(string nombre, int numeroLibreta)
        {
            switch (Orden)
            {
                case 0:
                    Nombre0 = nombre;
                    NumeroLibreta0 = numeroLibreta;
                    Orden++;
                    break;
                case 1:
                    Nombre1 = nombre;
                    NumeroLibreta1 = numeroLibreta;
                    Orden++;
                    break;
                case 2:
                    Nombre2 = nombre;
                    NumeroLibreta2 = numeroLibreta;
                    Orden++;
                    break;
            }
        }
    }
}
