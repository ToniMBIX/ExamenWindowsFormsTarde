using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenWindowsFormsTarde.models;

namespace ExamenWindowsFormsTarde.models
{
    internal class jugadorEstrella : Jugador
    {
        double PuntosPorPartido;

        public jugadorEstrella(string nombre, string posicion, float altura, string equipo) : base(nombre, posicion, altura, equipo)
        {
        }
    }
}
