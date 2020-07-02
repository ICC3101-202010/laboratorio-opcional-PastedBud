using System;
using System.Collections.Generic;

namespace Examen2019
{
    public class Embarcacion
    {
        private string nombre;
        private int vidas;
        private List<int> posicion = new List<int>();
        private string manera;
        public Portaaviones portaaviones = new Portaaviones();
        public Fragata fragata = new Fragata();
        public Submarino submarino = new Submarino();
        public Reparador reparador = new Reparador();
        public Radar radar = new Radar();

        public string Nombre { get => nombre; set => nombre = value; }
        public int Vidas { get => vidas; set => vidas = value; }
        public List<int> Posicion { get => posicion; set => posicion = value; }
        public string Manera { get => manera; set => manera = value; }

        public Embarcacion()
        {
        }
    }
}
