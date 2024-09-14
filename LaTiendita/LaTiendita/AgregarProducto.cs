using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaTiendita
{
    public partial class AgregarProducto : Form
    {
        ManejadorUsuario mu;
        public AgregarProducto()
        {
            InitializeComponent();
            mu = new ManejadorUsuario();
            if (BuscarUsuario.idProducto > 0)
            {
                txtNombre.Text = BuscarUsuario.Usuario.ToString();
                txtDescripcion.Text = BuscarUsuario.Contrasena.ToString();
                txtPrecio.Text = BuscarUsuario.Nivel.ToString();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (BuscarUsuario.idProducto > 0)
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Completa todos los datos", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mu.Modificar(BuscarUsuario.idProducto, txtNombre, txtDescripcion, txtPrecio);
                    Close();
                    BuscarUsuario bu = new BuscarUsuario();
                    bu.Show();
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
                    MessageBox.Show(mu.Guardar(txtNombre, txtDescripcion, txtPrecio), "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            Close();
        }
    }
}
