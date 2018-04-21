using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Producto prod;
        Inventario inv = new Inventario();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            prod = new Producto(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text,Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            inv.AddProduct(prod, Convert.ToInt32(txtCodigo.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtMonitor.Text = inv.ListAllProducts();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

                inv.DeleteProduct(Convert.ToInt32(txtPosition.Text));

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           txtMonitor.Text =  inv.SearchProduct(txtPosition.Text).ToString();
        }

   
    }
}
