using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CACHO01
{
    class NodoDado
    {
        int num;
        int pos;
        NodoDado enlace;

        public NodoDado(int posi)
        {
            this.Pos = posi;
        }

        public int Num { get => num; set => num = value; }
        public NodoDado Enlace { get => enlace; set => enlace = value; }
        public int Pos { get => pos; set => pos = value; }
    }
}
