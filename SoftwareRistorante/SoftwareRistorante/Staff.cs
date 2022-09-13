using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoftwareRistorante
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Visualizzare_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./File.txt"); ;
            string y = sr.ReadLine();
            string write = null;
            while (y != null)
            {
                if (y.Split(';')[4] == "True")
                {
                    string n = $"Portata: {y.Split(';')[0]}\nNome: {y.Split(';')[1]}\nDescrizione: {y.Split(';')[2]}\nPrezzo: {y.Split(';')[3]}";
                    write += n + "\n\n";
                }
                y = sr.ReadLine();
            }
        }

        private void Ricerca_Click(object sender, EventArgs e)
        {
            Ricercare x = new Ricercare();
            this.Visible = false;
            x.ShowDialog();
            this.Visible = true;
        }

        private void Aggiungere_Click(object sender, EventArgs e)
        {
            Aggiungere x = new Aggiungere();
            this.Visible = false;
            x.ShowDialog();
            this.Visible = true;
        }

        private void Modificare_Click(object sender, EventArgs e)
        {
            Modifica x = new Modifica();
            this.Visible = false;
            x.ShowDialog();
            this.Visible = true;
        }

        private void Eliminare_Click(object sender, EventArgs e)
        {
            Eliminare x = new Eliminare();
            this.Visible = false;
            x.ShowDialog();
            this.Visible = true;
        }

        private void Recupera_Click(object sender, EventArgs e)
        {
            Recuperare x = new Recuperare();
            this.Visible = false;
            x.ShowDialog();
            this.Visible = true;
        }

        private void GestioneMenù_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
