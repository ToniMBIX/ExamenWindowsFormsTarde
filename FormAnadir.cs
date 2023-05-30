using ExamenWindowsFormsTarde.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenWindowsFormsTarde.models;
using System.Collections;
using ExamenWindowsFormsTarde;

namespace ExamenWindowsFormsTarde
{
    public partial class FormAnadir : Form
    {
        ArrayList listaJugadores = Lista.listaJugadores;
        private FormLista formLista;

        public FormAnadir(FormLista formLista)
        {
            InitializeComponent();
            this.formLista = formLista;
        }

        private void maskedTextBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxNombre == null)
            {
                maskedTextBoxNombre.BackColor = Color.Red;
            }
            else
            {
                maskedTextBoxNombre.BackColor = Color.Green;
            }
        }

        private void maskedTextBoxEquipo_Validating(object sender, CancelEventArgs e)
        {
            if(maskedTextBoxEquipo == null)
            {
                maskedTextBoxEquipo.BackColor = Color.Red;
            }
            else
            {
                maskedTextBoxEquipo.BackColor = Color.Green;
            }
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            listaJugadores.Add(new Jugador(maskedTextBoxNombre.Text, comboBoxPosicion.Text, float.Parse(maskedTextBoxAltura.Text), maskedTextBoxEquipo.Text));
            formLista.actualizarListView();
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBoxAltura_Validated(object sender, EventArgs e)
        {
            if (maskedTextBoxAltura == null)
            {
                maskedTextBoxAltura.BackColor = Color.Red;
            }
            else
            {
                maskedTextBoxAltura.BackColor = Color.Green;
            }

        }

        private void comboBoxPosicion_Validated(object sender, EventArgs e)
        {
            if (comboBoxPosicion == null)
            {
                comboBoxPosicion.BackColor = Color.Red;
            }
            else
            {
                comboBoxPosicion.BackColor = Color.Green;
            }

        }
    }
}
