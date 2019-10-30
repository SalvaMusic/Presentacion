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
        #region Atributos
        List<Pedido> listaPedidos;
        List<Producto> listaProductos;
        Cliente cliente;
        Pedido pedido;
        Xml<List<Pedido>> xml;
        string pathXml = "Datos\\Pedidos.Xml";
        bool registro = false;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor, inicializa los atributos.
        /// </summary>
        /// <param name="c">Cliente que va a crear el pedido</param>
        public FormPedido(Cliente c)
        {
            InitializeComponent();
            listaPedidos = new List<Pedido>();
            listaProductos = new List<Producto>();
            xml = new Xml<List<Pedido>>();
            cliente = c;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Carga los productos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPedido_Load(object sender, EventArgs e)
        {
            try
            {
                cargaAutomaticaProductos();
                cargaProductosdGVProdPedir();
                mtxtCantidad.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Crea productos y los agrega a la lista de productos.
        /// </summary>
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

        /// <summary>
        /// Carga los productos de la lista y los agrega a dGVProdPedir.
        /// </summary>
        private void cargaProductosdGVProdPedir()
        {
            foreach (Producto p in listaProductos)
            {
                dGVProdPedir.Rows.Add(p.Codigo, p.Nombre, p.Precio);
            }
        }

        /// <summary>
        /// Método de Evento click, Agrega el producto seleccionado de dGVProdPedir a dGVPrePedido para su proceso de pedido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lblCodigo.Text))
            {
                MessageBox.Show("Seleccione Código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (String.IsNullOrEmpty(mtxtCantidad.Text))
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

        /// <summary>
        /// Método de Evento Click, si el cliente confirma el pedido lo guarda en un Xml.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                List<Producto> prodPedido = new List<Producto>();
                for (int i = 0; i < dGVPrePedido.Rows.Count - 1; i++)
                {
                    foreach (Producto p in listaProductos)
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

                if (MessageBox.Show("TOTAL BRUTO: " + pedido.TotalBrutoPedido, "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    pedido.Estado = Estado.Facturado;
                    cargarPedidosXml();
                    listaPedidos.Add(pedido);
                    registro = true;
                    MessageBox.Show("Pedido cargado en estado 'Pendiente'", "Confirmado",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
                    guardarPedidosXml();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Método de evento cell click, muestra el código de producto de la celda celeccionada en un lblCodigo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGVProdPedir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1 && n < listaProductos.Count)
            {
                lblCodigo.Text = dGVProdPedir.Rows[n].Cells[0].Value.ToString();
                mtxtCantidad.Focus();
            }
        }

        /// <summary>
        /// Guarda los pedidos en un Xml.
        /// </summary>
        private void guardarPedidosXml()
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

        /// <summary>
        /// Carga los pedidos previamente serializados en el Xml y los agrega a la lista de pedidos.
        /// </summary>
        private void cargarPedidosXml()
        {
            if (File.Exists(pathXml))
            {
                xml.Leer(pathXml, out listaPedidos);
                if (listaPedidos.Count > 0)
                {
                    Pedido.nroPedStatic = listaPedidos[listaPedidos.Count - 1].NroPedido;
                }

            }
        } 

        #endregion
    }
}
