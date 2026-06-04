using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    internal class Servicio
    {
        public string Jugador1;
        private int setGanados1 = 0;
        public string Jugador2;
        private int setGanados2 = 0;
        
        public void RegistrarJugadores(string Nombre1, string Nombre2)
        {
            Jugador1 = Nombre1;
            Jugador2 = Nombre2;
        }
        public void RegistrarResultadoSet(int resultado1, int resultado2)
        {
          if (resultado1 > resultado2)
            {
                setGanados1++;
            }
            else if (resultado2 > resultado1)
            {
                setGanados2++;
            }

        }
            public string DeterminarGanador()
        {
            if (setGanados1 > setGanados2)
            {
                return Jugador1;
            }
            else if (setGanados2 > setGanados1)
            {
                return Jugador2;
            }
            else
            {
                return "El partido está empatado.";
            }
        }
    }
}
