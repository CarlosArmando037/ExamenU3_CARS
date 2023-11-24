using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExamenU3_CARS.Clases
{
    public class Nodo
    {
        //no se si persona esta bien
        /*
        public Persona _persona { get; set; }
        public Nodo _Siguiente { get; set; }

        public Nodo(Persona persona) 
        {
            _persona = persona;
            _Siguiente = null;
        }
        public Nodo(Persona persona, Nodo siguiente)
        {
            _persona = persona;
            _Siguiente = siguiente;
        }

        public Persona persona { get { return persona; } set { persona = value; } }
        public Nodo siguiente { get { return siguiente; } set { siguiente = value; } }
        */

        public Persona _persona;
        public Nodo _siguiente;
        //public Persona persona1 { get; set; } 
        public Nodo(Persona persona)
        {
            _persona = persona;
            _siguiente = null;
        }
         
        public Nodo(Persona persona,Nodo siguiente)
        {
            _persona = persona;
            _siguiente = siguiente;
        }
        //public Persona persona { get; set; }

        public Persona GetPersona()
        {
            return _persona;
        }
        public Nodo GetNodo()
        {
            return _siguiente;
        }
    }
}
