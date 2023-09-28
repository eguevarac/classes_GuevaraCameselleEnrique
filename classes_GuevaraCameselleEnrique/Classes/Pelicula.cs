using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_GuevaraCameselleEnrique.Classes
{
    internal class Pelicula
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public int Anyo { get; set; }
        public BindingList<string> Temas { get; set; }

        public Pelicula(string titulo, string director, int anyo, BindingList<string> temas)
        {
            this.Titulo = titulo;
            this.Director = director;
            this.Anyo = anyo;
            this.Temas = temas;
        }

        public Pelicula() { }

    }
}
