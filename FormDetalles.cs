using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenWindowsFormsTarde
{
    public partial class FormDetalles : Form
    {
        public FormDetalles(string nombre, string posicion, string altura, string equipo)
        {
            InitializeComponent();
            textBoxNombre.Text = nombre;
            textBoxPosicion.Text = posicion;
            textBoxAltura.Text = altura;
            textBoxEquipo.Text = equipo;
        }


        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
