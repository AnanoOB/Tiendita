using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace LaTiendita
{
    public partial class AgregarProducto : Form
    {
        ManejadorProductos mp;
        public AgregarProducto()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            if (BuscarProducto.idProductos > 0)
            {
                txtNombre.Text = BuscarProducto.Nombre.ToString();
                txtDescripcion.Text = BuscarProducto.Descripcion.ToString();
                txtPrecio.Text = BuscarProducto.Precio.ToString();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (BuscarProducto.idProductos > 0)
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Completa todos los datos", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mp.Modificar(BuscarProducto.idProductos, txtNombre, txtDescripcion, txtPrecio);
                    Close();
                    BuscarProducto bp = new BuscarProducto();
                    bp.Show();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Complete todos los datos");

                }
                else
                {
                    MessageBox.Show(mp.Guardar(txtNombre, txtDescripcion, txtPrecio), "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            Close();
        }
    }
}
