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
    public partial class FormPedido : Form
    {
        List<Producto> listaProductos;
        Cliente cliente = null;
        Pedido pedido;
      
        public FormPedido(Cliente c)
        {
            InitializeComponent();
            listaProductos = new List<Producto>();
            cliente = c;
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            cargaAutomaticaPedidos();
            cargaPedidosListBox();
            mtxtCantidad.Text = "";

        }

        private void cargaAutomaticaPedidos()
        {
            listaProductos.Add(new Producto("2526", "Cuerdas de Guitarra", 150));
            listaProductos.Add(new Producto("2527", "Puas de Guitarra", 50));
            listaProductos.Add(new Producto("2528", "Afinador de Guitarra", 500));
            listaProductos.Add(new Producto("2529", "Bafles de Guitarra", 12000));
            listaProductos.Add(new Producto("8526", "Cuerdas de Bajo", 600));
            listaProductos.Add(new Producto("8527", "Puas de Bajo", 100));
            listaProductos.Add(new Producto("8528", "Afinador de Bajo", 5000));
            listaProductos.Add(new Producto("8529", "Bafles de Bajo", 15000));
        }

        private void cargaPedidosListBox()
        {
            foreach (Producto p in listaProductos)
            {
                dataGridViewProdPedir.Rows.Add(p.Codigo, p.Nombre, p.Precio);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lblCodigo.Text))
            {
                MessageBox.Show("Seleccione Código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else if (String.IsNullOrEmpty(mtxtCantidad.Text))
            {
                MessageBox.Show("Ingrese Cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                dataGridViewPrePedido.Rows.Add(lblCodigo.Text, mtxtCantidad.Text);
                lblCodigo.Text = "";
                mtxtCantidad.Text = "";
            }
            

        }
      

        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            List<Producto> prodPedido = new List<Producto>();
            for (int i = 0; i< dataGridViewPrePedido.Rows.Count -1; i++)
            {
                foreach(Producto p in listaProductos)
                {
                    if (dataGridViewPrePedido.Rows[i].Cells[0].Value.ToString() == p.Codigo)
                    {
                        p.Cantidad = Convert.ToInt16(dataGridViewPrePedido.Rows[i].Cells[1].Value.ToString());
                        prodPedido.Add(p);
                        break;
                    }
                }
            }
            pedido = new Pedido(cliente, prodPedido);
            if (MessageBox.Show("TOTAL BRUTO: "+pedido.TotalBrutoPedido,"Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                pedido.Estado = Estado.Pendiente;
                MessageBox.Show("Pedido cargado en estado 'Pendiente'", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        private void txtProductoAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProdPedir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                lblCodigo.Text = dataGridViewProdPedir.Rows[n].Cells[0].Value.ToString();
                mtxtCantidad.Focus();
            }
                 
        }
    }
}
