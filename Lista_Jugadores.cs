using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACHO01
{
    class Lista_Jugadores
    {
        Nodo_Jugador cabeza, nuevo, ultimo;

        public Lista_Jugadores()
        {
            cabeza = null;
            nuevo = null;
            ultimo = null;
        }

        public void crear_nodo(String name, int num)
        {
            nuevo = new Nodo_Jugador(name, num);
        }

        public void crear_lista_circular(String name, int num)
        {
            crear_nodo(name, num);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                ultimo.Enlace = nuevo;
            }
            ultimo = nuevo;
            ultimo.Enlace = cabeza;
        }

        public Nodo_Jugador getCabeza()
        {
            return cabeza;
        }

        public Nodo_Jugador getUltimo()
        {
            return ultimo;
        }

        public void obtenerPuntajesTotales()
        {
            Nodo_Jugador jug = cabeza;
            do
            {
                jug = jug.Enlace;
            } while (jug != cabeza);
        }

        public void ordenar()
        {
            Nodo_Jugador punt = cabeza;
            Nodo_Jugador punt1;
            do
            {
                punt1 = punt.Enlace;
                while (punt1 != cabeza)
                {
                    if (punt.puntajeMax() < punt1.puntajeMax())
                    {
                        //Rescatamos todo en variables auxiliares
                        String nombreAux = punt.Nombre;
                        int[] puntajeAux = new int[11];
                        int numero_jugador = punt.Numero_jugador;

                        for (int i = 0; i < 11; i++)
                        {
                            puntajeAux[i] = punt.Puntaje[i];
                        }

                        //INTERCAMBIAMOS LOS DATOS
                        punt.Numero_jugador = punt1.Numero_jugador;
                        punt.Nombre = punt1.Nombre;
                        for (int i = 0; i < 11; i++)
                        {
                            punt.Puntaje[i] = punt1.Puntaje[i];
                        }

                        punt1.Numero_jugador = numero_jugador;
                        punt1.Nombre = nombreAux;
                        for (int i = 0; i < punt.Puntaje.Length; i++)
                        {
                            punt1.Puntaje[i] = puntajeAux[i];
                        }
                    }

                    punt1 = punt1.Enlace;
                }

                punt = punt.Enlace;
            } while (punt != ultimo);
        }

        public int getTam()
        {
            int max = 0;
            Nodo_Jugador cab = cabeza;
            do
            {
                if(max < cab.Numero_jugador)
                {
                    max = cab.Numero_jugador;
                }
                cab = cab.Enlace;
            } while (cab != cabeza);
            return max;
        }
    }
}
