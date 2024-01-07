using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACHO01
{
    class listaDobleCircularReglas
    {
        NodoReglas cabeza, nuevo, ultimo;
        public listaDobleCircularReglas()
        {
            cabeza = null;
            nuevo = null;
        }
        public NodoReglas getCabeza()
        {
            return cabeza;
        }
        public NodoReglas getUltimo()
        {
            return ultimo;
        }
        public void crearNodo(int n)
        {
            nuevo = new NodoReglas();
            nuevo.setNum(n);
            nuevo.setSig(null);
            nuevo.setAnt(null);
        }
        public void crearLista(int n)
        {
            NodoReglas punt;
            crearNodo(n);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                ultimo.setSig(nuevo);
                nuevo.setAnt(ultimo);
            }
            ultimo = nuevo;
            ultimo.setSig(cabeza);
            cabeza.setAnt(ultimo);

        }
        public string eliminar(int n)
        {
            NodoReglas actual = cabeza;
            NodoReglas anterior = ultimo;
            if (cabeza.getNum() == n)
            {
                if (cabeza == ultimo)
                {
                    cabeza = null;
                    ultimo = null;
                    return ("SE ELIMINO A NUMERO:" + n);
                }
                ultimo.setSig(cabeza.getSig());

                cabeza = cabeza.getSig();
                cabeza.setAnt(ultimo);

                actual.setSig(null);
                actual.setAnt(null);
                return ("SE ELIMINO A NUMERO:" + actual.getNum());
            }
            if (ultimo.getNum() == n)
            {
                ultimo.getAnt().setSig(cabeza);
                cabeza.setAnt(ultimo.getAnt());
                ultimo = ultimo.getAnt();
                anterior.setAnt(null);
                anterior.setSig(null);

                return ("SE ELIMINO A NUMERO:" + actual.getNum());
            }
            do
            {
                if (actual.getNum() == n)
                {
                    anterior.setSig(actual.getSig());
                    actual.getSig().setAnt(anterior);
                    actual.setSig(null);
                    actual.setAnt(null);
                    return ("SE ELIMINO A NUMERO:" + actual.getNum());
                }
                anterior = actual;
                actual = actual.getSig();

            } while (actual != cabeza);
            return "NO EXISTE";
        }
        public void ordenar()
        {
            int aux;
            NodoReglas punt = cabeza;
            do
            {
                NodoReglas punt2 = punt.getSig();
                while (punt2 != cabeza)
                {
                    if (punt2.getNum() < punt.getNum())
                    {
                        aux = punt.getNum();
                        punt.setNum(punt2.getNum());
                        punt2.setNum(aux);
                    }
                    punt2 = punt2.getSig();
                }
                punt = punt.getSig();
            } while (punt != cabeza);
        }
        public void insertar(int n)
        {
            NodoReglas actual = cabeza;
            NodoReglas anterior = ultimo;
            crearNodo(n);
            if (cabeza.getNum() >= nuevo.getNum())
            {
                nuevo.setSig(cabeza);
                cabeza.setAnt(nuevo);
                cabeza = nuevo;
                ultimo.setSig(cabeza);
                cabeza.setAnt(ultimo);
            }

            else if (ultimo.getNum() <= nuevo.getNum())
            {
                ultimo.setSig(nuevo);
                nuevo.setAnt(ultimo);
                ultimo = nuevo;
                ultimo.setSig(cabeza);
                cabeza.setAnt(ultimo);
            }
            else
            {
                while (actual.getNum() < nuevo.getNum())
                {
                    anterior = actual;
                    actual = actual.getSig();

                }
                anterior.setSig(nuevo);
                nuevo.setSig(actual);
                nuevo.setAnt(anterior);
                actual.setAnt(nuevo);
            }

        }
    }
}
