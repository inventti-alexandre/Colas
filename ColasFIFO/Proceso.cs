using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Proceso
    {
        private int _espera;
        private Proceso _siguiente;
        Random rn = new Random();

        public Proceso()
        {
            _espera = rn.Next(4, 15);
            _siguiente = null;
        }

        public int Espera
        {
            get { return _espera; }
            set { _espera = value; }
        }

        public Proceso Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}
