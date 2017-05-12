using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutas
{
    class Base
    {
        private string _nombre { get; }
        private DateTime _minutos { get; }
        public Base siguiente;
        public Base(string nombre, DateTime minutos)
        {
            _nombre = nombre;
            _minutos = minutos;
        }
        public string nombre
        {
            get { return _nombre; }
        }
        public DateTime minutos
        {
            get { return _minutos; }
        }
        public override string ToString()
        {
            string resultado = "";
            resultado += "Nombre: " + _nombre + " Minutos: "+_minutos+".";
            return resultado;
        }
    }
}
