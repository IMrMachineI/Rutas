using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutas
{
    class Ruta
    {
        private Base inicio;
        public Ruta()
        {
            inicio = null;
        }
        public void agregarBase(Base nuevaBase)
        {
            bool sePuedeAgregar = true;
            if(inicio == null)
            {
                inicio = nuevaBase;
                nuevaBase.siguiente = inicio;
            }
            else
            {
                Base varTemporal = inicio;
                while(varTemporal.siguiente != inicio && sePuedeAgregar != false)
                {
                    if(varTemporal.nombre == nuevaBase.nombre)
                    {
                        sePuedeAgregar = false;
                    }
                }
                if(sePuedeAgregar == true && varTemporal.nombre != nuevaBase.nombre)
                {
                    varTemporal.siguiente = nuevaBase;
                    nuevaBase.siguiente = inicio;
                }
            }
        }
        public void agregarInicio(Base nuevaBase)
        {
            Base varTemporal = inicio;
            bool sePuedeAgregar = true;
            if(inicio == null)
            {
                inicio = nuevaBase;
                nuevaBase.siguiente = inicio;
            }
            else
            {
                while(varTemporal.siguiente != inicio && sePuedeAgregar != false)
                {
                    if(varTemporal.nombre == nuevaBase.nombre)
                    {
                        sePuedeAgregar = false;
                    }
                    varTemporal = varTemporal.siguiente;
                }
                if(varTemporal.nombre != nuevaBase.nombre && sePuedeAgregar == true)
                {
                    nuevaBase.siguiente = inicio;
                    inicio = nuevaBase;
                    varTemporal.siguiente = inicio;
                }
            }
        }
        public Base buscarBase(string nombreBase)
        {
            Base varTemporal = inicio;
            while(varTemporal.siguiente != inicio && varTemporal.nombre != nombreBase)
            {
                varTemporal = varTemporal.siguiente;
            }
            return varTemporal;
        }
        public void eliminar(string nombreBase)
        {
            Base varTemporal = inicio;
            if(varTemporal.nombre == nombreBase)
            {
                if(varTemporal.siguiente == inicio)
                {
                    varTemporal = null;
                    inicio = varTemporal;
                }
                else
                {
                    while(varTemporal != inicio)
                    {
                        varTemporal = varTemporal.siguiente;
                    }
                    varTemporal.siguiente = inicio.siguiente;
                    inicio = inicio.siguiente;
                }
            }
        }
        public string reporte()
        {
            string resultado = "";
            Base varTemporal = inicio;
            if(varTemporal != null)
            {
                while(varTemporal.siguiente != inicio)
                {
                    resultado += varTemporal.ToString();
                    varTemporal = varTemporal.siguiente;
                }
                resultado += varTemporal.ToString();
                return resultado;
            }
            else
            {
                return "";
            }
        }
        public void insertarBase(string nombreBase, Base nuevaBase)
        {
            Base varTemporal = buscarBase(nombreBase);
            nuevaBase.siguiente = varTemporal.siguiente;
            varTemporal.siguiente = nuevaBase;
        }
    }
}
