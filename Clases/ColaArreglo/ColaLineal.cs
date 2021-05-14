using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.Clases.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 39;//tipo de dato constante
        protected int frente;

        protected Object[] ListaCola;

        //constructor
        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            ListaCola = new object[MAXTAMQ];//inicializamos
        }

        public bool colaVacia()
        {
            return frente > fin; 
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }

        //operacion para trabajar con datos en la cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                ListaCola[++fin] = elemento; //primero toma la variable luego incrementea
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //quitar elemento de la cola
        public Object quitar()
        {
            if (!colaVacia())
            {
                return ListaCola[frente++];
            }
            else
            {
                throw new Exception("Cola Vacia"); 
            }
        }

        //Limpiar toda la cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //acceso a la cola
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return ListaCola[frente];
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }

    }//end class
}
