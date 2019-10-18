using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    [Serializable]
    public class Producto 
    {
        private string codigo;
        private string nombre;
        private float precio;
        private int cantidad;

        private Producto() { }

        public Producto(string codigo, string nombre, float precio) : this (codigo, nombre, precio, 0) { }

        public Producto(string codigo, string nombre, float precio,int  cantidad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { this.cantidad = value; }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0,6}\t{1,20}\t${2,10:n2}{3,6}", Codigo, Nombre, Precio, Cantidad);

            return str.ToString();
        }


    }
}
