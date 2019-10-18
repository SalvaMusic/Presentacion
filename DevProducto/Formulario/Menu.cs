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
        Cliente c;
        public Menu(Cliente cliente)
        {
            InitializeComponent();
            c = cliente;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string str1 = "N° Cliente: " + c.NroCliente;
            string str2 = c.TipoDocu + ": " + c.NroDocu;
            lblClientea.Text = str1;
            lblClienteb.Text = str2;
        }

        private void btnCrearPedidoMenu_Click(object sender, EventArgs e)
        {
            FormPedido p = new FormPedido(c);
            p.ShowDialog();
            
        }
    }
}
