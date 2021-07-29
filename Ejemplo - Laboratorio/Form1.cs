using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo___Laboratorio
{
    public partial class FormularioEjemplo : Form
    {
        public FormularioEjemplo()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "Hola como estan, este es un ejemplo";
        }

        private void lblSaludo_TextChanged(object sender, EventArgs e)
        {
            lblCambio.Text = "El texto tuvo un pequeño cambio, favo revisar si es el correcto";
        }

        private void cbEjemplo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCambio.Text = Convert.ToString(cbEjemplo.SelectedItem);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblTexto.Text = "Mucho gusto, su nombre es: " + txtNombre.Text
                            + "Y la materia seleccionada es: " + Convert.ToString(cbEjemplo.SelectedItem);
        }
    }
}
