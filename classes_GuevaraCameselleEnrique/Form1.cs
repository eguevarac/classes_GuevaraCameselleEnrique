using classes_GuevaraCameselleEnrique.Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace classes_GuevaraCameselleEnrique
{
    public partial class FormFilm : Form
    {
        BindingList<Pelicula> pelis = new BindingList<Pelicula>();

        public FormFilm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Pelicula peli = new Pelicula();
            int anyo;

            if (int.TryParse(textBoxYear.Text, out anyo))
            {
                IntroducirPeli(peli, anyo);
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IntroducirPeli(Pelicula peli, int anyo)
        {
            if (!textBoxTitle.Text.Equals("") && !textBoxDirector.Text.Equals(""))
            {
                DefinirPeli(peli, anyo);

                AnyadirPeli(peli);

                LimpiarBoxes();
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefinirPeli(Pelicula peli, int anyo)
        {
            peli.Titulo = textBoxTitle.Text;
            peli.Director = textBoxDirector.Text;
            peli.Anyo = anyo;
            peli.Temas = new BindingList<string>();

            foreach (string topic in listBoxTopics.SelectedItems)
            {
                peli.Temas.Add(topic);
            }
        }

        private void AnyadirPeli(Pelicula peli)
        {
            bool enLista;

            enLista = ChequearSiEnLista(peli);

            if (!enLista)
            {
                pelis.Add(peli);

                ActualizarListaDePelis();
            }
            else
            {
                MessageBox.Show("Película ya en la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool ChequearSiEnLista(Pelicula peli)
        {
            bool isInTheList = false;

            //Uso este foreach porque el Contains no me identifica el objeto
            foreach (Pelicula p in pelis)
            {
                if (p.Titulo.Equals(peli.Titulo))
                {
                    isInTheList = true;
                }
            }
            return isInTheList;
        }

        private void ActualizarListaDePelis()
        {
            listBoxFilms.DataSource = pelis;
            listBoxFilms.DisplayMember = "Titulo";
        }

        private void LimpiarBoxes()
        {
            textBoxTitle.Text = string.Empty;
            textBoxDirector.Text = string.Empty;
            textBoxYear.Text = string.Empty;
            listBoxTopics.ClearSelected();
            listBoxFilms.ClearSelected();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Pelicula peliculaParaBorrar = (Pelicula) listBoxFilms.SelectedItem;

            pelis.Remove(peliculaParaBorrar);

            ActualizarListaDePelis();

            LimpiarBoxes();

        }

        private void listBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*si no lo limpio primero, se me quedan todos los
             elementos marcados del listBoxTopics a medida que voy cambiando
            de película*/
            listBoxTopics.ClearSelected();

            if (listBoxFilms.SelectedItem != null)
            {
                MostrarPelicula();
            }
        }

        private void MostrarPelicula()
        {
            int index;

            Pelicula peliculaParaMostrar = (Pelicula)listBoxFilms.SelectedItem;
            textBoxTitle.Text = peliculaParaMostrar.Titulo;
            textBoxDirector.Text = peliculaParaMostrar.Director;
            textBoxYear.Text = Convert.ToString(peliculaParaMostrar.Anyo);

            foreach (string tema in peliculaParaMostrar.Temas)
            {
                index = listBoxTopics.FindString(tema);
                listBoxTopics.SetSelected(index, true);

            }
        }
    }
}
