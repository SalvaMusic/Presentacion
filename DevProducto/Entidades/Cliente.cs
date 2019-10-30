using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    
    #region Enumeradores
    /// <summary>
    /// Enumerador para tipo de documento
    /// </summary>
    public enum TDocum { DNI, CUIT }

    /// <summary>
    /// Enumerador para Condicion de Iva
    /// </summary>
    public enum CIva { Monotrivutista, IVA_Responsable_Inscripto, IVA_No_Responsable }
    # endregion
   
    
    /// <summary>
    /// Clase Cliente, serializable 
    /// </summary>
    ///
    [Serializable]
    public class Cliente
    {
        #region Atributos
        public static int nroCliStatic;
        private int nroCliente;
        private string domicilio;
        private CIva condIva;
        private TDocum tipoDocu;
        private string nroDocu; 
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Cliente() { }

        /// <summary>
        /// Constructor público con parametros 
        /// </summary>
        public Cliente(string domicilio, CIva condIva, TDocum tipoDocu, string nroDocu)
        {
            Cliente.nroCliStatic++;
            this.nroCliente = Cliente.nroCliStatic;
            this.domicilio = domicilio;
            this.condIva = condIva;
            this.tipoDocu = tipoDocu;
            this.nroDocu = nroDocu;
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Override de método ToString
        /// </summary>
        /// <returns>Un obj StrinBuilder con los datos del Cliente</returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("N° Cliente: {0}\tDomicilio: {1}\t{3}: {4}\nCondicion Impositiva: {2}",
                NroCliente, Domicilio, CondIva.ToString(), TipoDocu, NroDocu);

            return str.ToString();
        }

        /// <summary>
        /// Calcula el porcentaje de iva segun condicion impositiva del cliente
        /// </summary>
        /// <returns>Porcentaje correspondiente</returns>
        private float calcularPorcentaje()
        {
            float porc = 70;
            switch (this.CondIva)
            {
                case CIva.IVA_Responsable_Inscripto:
                    porc = (float)10.05;
                    break;
                case CIva.Monotrivutista:
                    porc = 21;
                    break;
            }
            return porc;
        }
        #endregion


        #region Propiedades

        /// <summary>
        /// Propiedad de lectura para el porcentaje del cliente
        /// </summary>
        public float Porc
        {
            get { return calcularPorcentaje(); }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el Numero del cliente
        /// </summary>
        public int NroCliente
        {
            get { return nroCliente; }
            set { nroCliente = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el Domicilio del cliente
        /// </summary>
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para la condicion impositiva del cliente
        /// </summary>
        public CIva CondIva
        {
            get { return condIva; }
            set { condIva = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el tipo de documento del cliente
        /// </summary>
        public TDocum TipoDocu
        {
            get { return tipoDocu; }
            set { tipoDocu = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el Numero de documento del cliente
        /// </summary>
        public string NroDocu
        {
            get { return nroDocu; }
            set { nroDocu = value; }
        } 
        #endregion

    }
}
