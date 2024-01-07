using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACHO01
{
    class NodoReglas
    {

        int num;
        NodoReglas sig;//Direccion del nodo con el que se enlasa
        NodoReglas ant;
        public NodoReglas()
        {
            num = 0;
            sig = null;
            ant = null;

        }
        public void setNum(int n)
        {
            this.num = n;
        }
        public void setSig(NodoReglas punt)
        {
            sig = punt;
        }

        public int getNum()
        {
            return num;
        }
        public NodoReglas getSig()
        {
            return sig;
        }
        public void setAnt(NodoReglas punt)
        {
            ant = punt;
        }
      
        public NodoReglas getAnt()
        {
            return ant;
        }
        public void pruebaPablo()
        {
            int g = 1 + 1;
            return;

        }

    }
}

