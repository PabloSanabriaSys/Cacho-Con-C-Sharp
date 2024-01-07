using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACHO01
{
    class Nodo_Jugador
    {
        String nombre;
        int [] puntaje;
        int numero_jugador;

        Nodo_Jugador enlace;

        public Nodo_Jugador(String name, int num)
        {
            this.nombre = name;
            puntaje = new int [11];
            puntaje[0] = -1;
            puntaje[1] = -1;
            puntaje[2] = -1;
            puntaje[3] = -1;
            puntaje[4] = -1;
            puntaje[5] = -1;
            puntaje[6] = -1;
            puntaje[7] = -1;
            puntaje[8] = -1;
            puntaje[9] = -1;
            puntaje[10] = -1;
            this.numero_jugador = num;
            enlace = null;
        }

        public int puntajeMax()
        {
            int punt = 0;
            for (int i = 0; i < puntaje.Length; i++)
            {
                if (puntaje[i] != -1) punt = punt + puntaje[i];
            }
            return punt;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int[] Puntaje { get => puntaje; set => puntaje = value; }
        public int Numero_jugador { get => numero_jugador; set => numero_jugador = value; }
        public Nodo_Jugador Enlace { get => enlace; set => enlace = value; }
    }
}
