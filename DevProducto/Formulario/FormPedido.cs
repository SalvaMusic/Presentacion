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
using Archivos;
using System.IO;

namespace Formulario
{
    public partial class FormPedido : Form
    {
        List<Pedido> listaPedidos;
        List<Producto> listaProductos;
        Cliente cliente;
        Pedido pedido;
        Xml<List<Pedido>> xml;
        string pathXml = "Datos\\Pedidos.Xml";
        bool registro = false;

        public FormPedido(Cliente c)
        {
            InitializeComponent();
            listaPedidos = new List<Pedido>();
            listaProductos = new List<Producto>();
            cliente = c;
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            try
            {
                cargaAutomaticaProductos();
                cargaProductosdGVProdPedir();
                mtxtCantidad.Text = "";
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cargaAutomaticaProductos()
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

        private void cargaProductosdGVProdPedir()
        {
            foreach (Producto p in listaProductos)
            {
                dGVProdPedir.Rows.Add(p.Codigo, p.Nombre, p.Precio);
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
                dGVPrePedido.Rows.Add(lblCodigo.Text, mtxtCantidad.Text);
                lblCodigo.Text = "";
                mtxtCantidad.Text = "";
            }
        }
      
        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            List<Producto> prodPedido = new List<Producto>();
            for (int i = 0; i< dGVPrePedido.Rows.Count -1; i++)
            {
                foreach(Producto p in listaProductos)
                {
                    if (dGVPrePedido.Rows[i].Cells[0].Value.ToString() == p.Codigo)
                    {
                        p.Cantidad = Convert.ToInt16(dGVPrePedido.Rows[i].Cells[1].Value.ToString());
                        prodPedido.Add(p);
                        break;
                    }
                }
            }
            pedido = new Pedido(cliente, prodPedido);
            if (MessageBox.Show("TOTAL BRUTO: "+pedido.TotalBrutoPedido,"Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                pedido.Estado = Estado.Pendiente;
                listaPedidos.Add(pedido);
                registro = true;
                MessageBox.Show("Pedido cargado en estado 'Pendiente'", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                this.Close();
            }
        }

        private void dGVProdPedir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                lblCodigo.Text = dGVProdPedir.Rows[n].Cells[0].Value.ToString();
                mtxtCantidad.Focus();
            }
        }

        private void FormPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (registro)
            {
                try
                {
                    xml.Guardar(pathXml, listaPedidos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void cargarPedidosXml()
        {
            if (File.Exists(pathXml))
            {
                xml.Leer(pathXml, out  listaPedidos);
                Pedido.nroPedStatic = listaPedidos[listaPedidos.Count - 1].NroPedido;
            }
        }
    }
}
