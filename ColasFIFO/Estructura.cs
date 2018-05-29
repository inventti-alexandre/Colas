using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Estructura
    {
        public Proceso primero = new Proceso();
        public Proceso ultimo = new Proceso(); 

        public Estructura()
        {
            primero = null;
            ultimo = null;
        }

        public void Agregar()
        {
            Proceso nuevo = new Proceso();

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
        }

        public void Eliminar()
        {
            primero = primero.Siguiente;
        }

        public void Decrecer()
        {
            Proceso actual = primero;
            while (actual != null)
            {
                if(actual.Espera>0)
                actual.Espera -= 1;

                actual = actual.Siguiente;
            }
        }
    }
}
