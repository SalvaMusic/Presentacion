using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class FormRegistrarse : Form
    {

        #region Delegados
        public delegate void pasar(Cliente c);
        #endregion
        #region Eventos
        public event pasar pasarCliente;
        #endregion
        #region Constructores
        public FormRegistrarse()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Carga los enumeradores "Tipo documento" y Condicion impositiva" para la seleccion del cliente. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRegistrarse_Load(object sender, EventArgs e)
        {
            cmbBoxTipoDocumento.DataSource = Enum.GetValues(typeof(TDocum));
            cmbBoxCondIva.DataSource = Enum.GetValues(typeof(CIva));

        }

        /// <summary>
        /// Método de evento click,toma los datos de un futuro cliente y los envia al form Menu a travez de un delegado y evento. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            TDocum TDocumento = TDocum.DNI;
            CIva CondIva = CIva.IVA_Responsable_Inscripto;

            if (cmbBoxTipoDocumento.Text == "CUIT") {
                TDocumento = TDocum.CUIT ;
            }

            if (cmbBoxCondIva.Text == "IVA_No_Responsable") {
                CondIva = CIva.IVA_No_Responsable;
            } else if (cmbBoxCondIva.Text == "Monotrivutista") {
                CondIva = CIva.Monotrivutista;
            }
                         
            Cliente c1 = new Cliente(textBoxDomicilio.Text, CondIva, TDocumento, maskTxtDocuRegistrarse.Text);
            
            MessageBox.Show("N° Cliente: " + c1.NroCliente);
            pasarCliente(c1);
            this.Dispose();

        }
        #endregion
    }
}
