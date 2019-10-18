using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class FormFacturacion : Form
    {
        Pedido pedido;
        public FormFacturacion(Pedido p)
        {
            InitializeComponent();
            pedido = p;
        }

        private void dataGridViewProdPedir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {
            cargaPedidosListBox();
        }

        private void cargaPedidosListBox()
        {
            int cant = 1, indexData = -1, i;
            bool existe = false;
            try
            {
                pedido.Detalles.Sort((p, q) => string.Compare(p.Nombre, q.Nombre));

                for (i = 0; i < pedido.Detalles.Count; i++)
                {
                    if (i > 0)
                    {
                        if (pedido.Detalles[i].Codigo == pedido.Detalles[i - 1].Codigo)
                        {
                            cant = (int) dataGridViewProdPedir.Rows[indexData].Cells[3].Value;
                            cant++;
                            dataGridViewProdPedir.Rows[indexData].Cells[3].Value = cant;
                            dataGridViewProdPedir.Rows[indexData].Cells[4].Value = cant * pedido.Detalles[i].Precio;
                            existe = true;
                            cant = 1;
                        }
                    }
                    if (!existe)
                    {
                        dataGridViewProdPedir.Rows.Add(pedido.Detalles[i].Codigo, pedido.Detalles[i].Nombre, pedido.Detalles[i].Precio, cant, cant * pedido.Detalles[i].Precio);
                        indexData++;
                    }
                    else
                    {
                        existe = false;
                    }
                }
                labelTotalBruto.Text = pedido.TotalBrutoPedido.ToString();
                pedido.Estado = Estado.Pendiente;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
