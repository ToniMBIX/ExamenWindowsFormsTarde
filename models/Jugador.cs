using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExamenWindowsFormsTarde.models
{
    internal class Jugador
    {
        public string Nombre;
        public string Posicion;
        public float Altura;
        public string Equipo;
        public Jugador(string nombre, string posicion, float altura, string equipo)
        {
            this.Nombre = nombre;
            this.Posicion = posicion;
            this.Altura = altura;
            this.Equipo = equipo;
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Posicion: {Posicion}, Altura: {Altura}, Equipo: {Equipo}";
        }
    }

}
