using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        protected string codigo;
        protected string nombre;
        protected float precio;

        public Producto(string codigo, string nombre, float precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Codigo
        {
            get { return codigo; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public float Precio
        {
            get { return precio; }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0,6}\t{1,20}\t${2,10:n2}", Codigo, Nombre, Precio);

            return str.ToString();
        }


    }
}
