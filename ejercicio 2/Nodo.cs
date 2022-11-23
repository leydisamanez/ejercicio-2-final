using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Nodo
    {
        public string  nombre;
        public double gana, pierde, total;
        private Nodo siguiente;
        internal Nodo Siguiente
        {
            get => siguiente; set => siguiente = value;
        }
        public Nodo(string nom, double pre, double stk)
        {
            
            nombre = nom;
            gana = pre*100;
            pierde = gana-20;
            total = pierde;
            siguiente = null;
        }
    }
}
