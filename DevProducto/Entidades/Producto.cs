using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    /// <summary>
    /// Clase Producto, Serializable
    /// </summary>
    [Serializable]
    public class Producto 
    {
        #region Atributos
        private string codigo;
        private string nombre;
        private float precio;
        private int cantidad;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Producto() { }

        /// <summary>
        /// Constructor Público con parametros 1.
        /// </summary>
        public Producto(string codigo, string nombre, float precio, int cantidad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Constructor Público con parametros 2, hereda de constructor 1 sin recibir el obj 'cantidad', inicializandola en 0.
        /// </summary>
        public Producto(string codigo, string nombre, float precio) : this (codigo, nombre, precio, 0) { }
        #endregion

        /// <summary>
        /// Propiedad de lectura y escritura para el codigo del producto.
        /// </summary>
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el Nombre del producto.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el Precio del producto.
        /// </summary>
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para la cantidad del producto.
        /// </summary>
        public int Cantidad
        {
            get { return cantidad; }
            set { this.cantidad = value; }
        }

        #region Métodos
        /// <summary>
        /// Override de método ToString.
        /// </summary>
        /// <returns>Un obj StrinBuilder con los datos del Producto</returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0,6}\t{1,20}\t${2,10:n2}{3,6}", Codigo, Nombre, Precio, Cantidad);

            return str.ToString();
        } 
        #endregion


    }
}
