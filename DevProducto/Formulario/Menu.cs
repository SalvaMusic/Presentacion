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
    public partial class Menu : Form
    {
        #region Atributos
        Cliente c;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor, inicializa los atributos.
        /// </summary>
        /// <param name="c">Cliente que va a crear o cancelar pedido</param>
        public Menu(Cliente cliente)
        {
            InitializeComponent();
            c = cliente;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Muestra la informacion del cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Load(object sender, EventArgs e)
        {
            string str1 = "N° Cliente: " + c.NroCliente;
            string str2 = c.TipoDocu + ": " + c.NroDocu;
            lblClientea.Text = str1;
            lblClienteb.Text = str2;
        }

        /// <summary>
        /// Método del evento click, Crea formlario para crear pedido y lo muestra. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearPedidoMenu_Click(object sender, EventArgs e)
        {
            FormPedido p = new FormPedido(c);
            p.ShowDialog();
        }
        /// <summary>
        /// Método del evento click, Crea formlario para cancelar pedido y lo muestra. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelarPedidoMenu_Click(object sender, EventArgs e)
        {
            FormCancelarPedido f = new FormCancelarPedido(c);
            f.ShowDialog();
        }
        
        #endregion
    }
}
