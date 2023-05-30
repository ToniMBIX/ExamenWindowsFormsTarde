using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenWindowsFormsTarde.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenWindowsFormsTarde
{
    public partial class FormLista : Form
    {
        ArrayList listaJugadores = Lista.listaJugadores;
        public FormLista()
        {
            InitializeComponent();

        }
        public void actualizarListView()
        {
            listViewJugadores.Items.Clear();
            foreach (Jugador jugador in listaJugadores)
            {
                ListViewItem lvi = new ListViewItem(jugador.Nombre);
                lvi.SubItems.Add(jugador.Posicion);
                lvi.SubItems.Add(jugador.Altura.ToString());
                lvi.SubItems.Add(jugador.Equipo);
                listViewJugadores.Items.Add(lvi);
            }
        }


        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Form FormAnadir = new FormAnadir(this);
            FormAnadir.ShowDialog();
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {
            if (listViewJugadores.SelectedItems.Count > 0)
            {
                string nombre = listViewJugadores.SelectedItems[0].SubItems[0].Text;
                string posicion = listViewJugadores.SelectedItems[0].SubItems[1].Text;
                string altura = listViewJugadores.SelectedItems[0].SubItems[2].Text;
                string equipo = listViewJugadores.SelectedItems[0].SubItems[3].Text;
                FormDetalles formDetalles = new FormDetalles(nombre, posicion, altura, equipo);
                formDetalles.Show();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listViewJugadores.SelectedItems.Count > 0) 
            {
                listViewJugadores.Items.Remove(listViewJugadores.SelectedItems[0]);
            }
        }

    }
}
