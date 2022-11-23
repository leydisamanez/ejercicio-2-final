using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Lista
    {
        Nodo primero;
        public Nodo raiz;
        public void insertar( string nombre, double gana, double pierde)
        {
            if (primero == null)
            {
                primero = new Nodo( nombre, gana, pierde);
                raiz = primero;
            }
            else
            {
                Nodo nuevo = new Nodo(nombre, gana, pierde);
                primero.Siguiente = nuevo;
                primero = nuevo;
            }
        }

        public void desplegar(DataGridView data)
        {
            Nodo actual;
            actual = raiz;
            data.Rows.Clear();
            while (actual != null)
            {
                data.Rows.Add( actual.nombre, actual.gana,
                actual.pierde, actual.total);
                actual = actual.Siguiente;
            }
        }
    }

}
