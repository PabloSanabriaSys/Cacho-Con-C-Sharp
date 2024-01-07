using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACHO01
{
    class ListaDados
    {
        NodoDado cabeza, nuevo;
        Random r;

        public NodoDado Cabeza { get => cabeza; set => cabeza = value; }

        public ListaDados()
        {
            cabeza = null;
            nuevo = null;
            r = new Random();
        }

        public void nuevo_nodo(int pos)
        {
            nuevo = new NodoDado(pos);
            nuevo.Num = r.Next(1,7);
            nuevo.Enlace = null;
        }

        public void crear_lista(int pos)
        {
            NodoDado punt;
            nuevo_nodo(pos);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                punt = cabeza;
                while (punt.Enlace != null)
                {
                    punt = punt.Enlace;
                }
                punt.Enlace = nuevo;
            }
        }

        public void ordenarDados()
        {
            NodoDado punt = cabeza;
            NodoDado punt1;
            while (punt != null)
            {
                punt1 = punt.Enlace;
                while (punt1 != null)
                {
                    if (punt.Num > punt1.Num)
                    {
                        int aux = punt.Num;
                        punt.Num = punt1.Num;                        
                        punt1.Num = aux;
                    }
                    punt1 = punt1.Enlace;
                }
                punt = punt.Enlace;
            }
        }

        public void tiroCubilete()
        {
            for(int i = 0; i<5; i++)
            {
                crear_lista(i);
            }
        }

        public NodoDado buscarDado(int pos)
        {
            NodoDado punt = cabeza;
            while (punt != null)
            {
                if (punt.Pos == pos)
                {
                    return punt;
                }
                punt = punt.Enlace;
            }
            return punt;
        }

        public void volveraLanzar(int pos)
        {
            NodoDado enct = buscarDado(pos);
            enct.Num = r.Next(1, 7);
        }

        public void volteardados(int pos)
        {
            NodoDado aux = buscarDado(pos);
            aux.Num = 7 - aux.Num;
        }

        public int comprobarMano(ref int pos)
        {
            ordenarDados();
            NodoDado aux = cabeza;
            NodoDado aux1 = aux.Enlace;
            NodoDado aux2 = aux1.Enlace;
            NodoDado aux3 = aux2.Enlace;
            NodoDado aux4 = aux3.Enlace;

            int i = 0;
            //DORMIDA
            if (aux.Num == aux1.Num && aux.Num == aux2.Num && aux.Num == aux3.Num && aux.Num == aux4.Num)
            {
                return 20000;
            }

            //ESCALERA
            if (aux.Num == 1 && aux1.Num == 2 && aux2.Num == 3 && aux3.Num == 4 && aux4.Num == 5)
            {
                pos = 7;
                return 25;
            }
            if (aux.Num == 2 && aux1.Num == 3 && aux2.Num == 4 && aux3.Num == 5 && aux4.Num == 6)
            {
                pos = 7;
                return 25;
            }
            if (aux.Num == 1 && aux1.Num == 3 && aux2.Num == 4 && aux3.Num == 5 && aux4.Num == 6)
            {
                pos = 7;
                return 25;
            }

            //FULL
            if (aux.Num == aux1.Num && aux.Num == aux2.Num && aux3.Num == aux4.Num)
            {
                pos = 8;
                return 35;
            }
            if (aux.Num == aux1.Num && aux2.Num == aux3.Num && aux2.Num == aux4.Num)
            {
                pos = 8;
                return 35;
            }

            //POKER
            if (aux.Num == aux1.Num && aux.Num == aux2.Num && aux.Num == aux3.Num)
            {
                pos = 9;
                return 45;
            }
            if (aux1.Num == aux2.Num && aux1.Num == aux3.Num && aux1.Num == aux4.Num)
            {
                pos = 9;
                return 45;
            }
            
            return 0;
        }

        public int puntajeJugada(int jug)
        {
            NodoDado aux = cabeza;
            NodoDado aux1 = aux.Enlace;
            NodoDado aux2 = aux1.Enlace;
            NodoDado aux3 = aux2.Enlace;
            NodoDado aux4 = aux3.Enlace;

            int con = 0, i, j;
            switch (jug)
            {
                case 1:
                    //BALAS
                    for (NodoDado auxiliar = cabeza; auxiliar != null; auxiliar = auxiliar.Enlace)
                    {
                        if (auxiliar.Num == 1) con++;
                    }
                    return con;

                case 2:
                    //TONTOS
                    for (NodoDado auxiliar = cabeza; auxiliar != null; auxiliar = auxiliar.Enlace)
                    {
                        if (auxiliar.Num == 2) con++;
                    }
                    return con * 2;

                case 3:
                    //TRENES
                    for (NodoDado auxiliar = cabeza; auxiliar != null; auxiliar = auxiliar.Enlace)
                    {
                        if (auxiliar.Num == 3) con++;
                    }
                    return con * 3;

                case 4:
                    //CUADRAS
                    for (NodoDado auxiliar = cabeza; auxiliar != null; auxiliar = auxiliar.Enlace)
                    {
                        if (auxiliar.Num == 4) con++;
                    }
                    return con * 4; ;

                case 5:
                    //QUINAS
                    for (NodoDado auxiliar = cabeza; auxiliar != null; auxiliar = auxiliar.Enlace)
                    {
                        if (auxiliar.Num == 5) con++;
                    }
                    return con * 5;

                case 6:
                    //SENAS
                    for (NodoDado auxiliar = cabeza; auxiliar != null; auxiliar = auxiliar.Enlace)
                    {
                        if (auxiliar.Num == 6) con++;
                    }
                    return con * 6;

                case 7:
                    //ESCALERA
                    if (aux.Num == 1 && aux1.Num == 2 && aux2.Num == 3 && aux3.Num == 4 && aux4.Num == 5)
                    {
                        return 20;
                    }
                    if (aux.Num == 2 && aux1.Num == 3 && aux2.Num == 4 && aux3.Num == 5 && aux4.Num == 6)
                    {
                        return 20;
                    }
                    if (aux.Num == 1 && aux1.Num == 3 && aux2.Num == 4 && aux3.Num == 5 && aux4.Num == 6)
                    {
                        return 20;
                    }
                    break;

                case 8:
                    //FULL
                    if (aux.Num == aux1.Num && aux.Num == aux2.Num && aux3.Num == aux4.Num)
                    {
                        return 30;
                    }
                    if (aux.Num == aux1.Num && aux2.Num == aux3.Num && aux2.Num == aux4.Num)
                    {
                        return 30;
                    }
                    break;

                case 9:
                    //POKER
                    if (aux.Num == aux1.Num && aux.Num == aux2.Num && aux.Num == aux3.Num)
                    {
                        return 40;
                    }
                    if (aux1.Num == aux2.Num && aux1.Num == aux3.Num && aux1.Num == aux4.Num)
                    {
                        return 40;
                    }
                    break;

                case 10:
                    //GRANDE 1
                    if (aux.Num == aux1.Num && aux.Num == aux2.Num && aux.Num == aux3.Num && aux.Num == aux4.Num)
                    {
                        return 50;
                    }
                    break;


                case 11:
                    //GRANDE 2
                    if (aux.Num == aux1.Num && aux.Num == aux2.Num && aux.Num == aux3.Num && aux.Num == aux4.Num) return 50;
                    break;

            }
            return 0;
        }
    }
}
