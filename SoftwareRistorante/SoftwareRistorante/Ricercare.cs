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
    public partial class Ricercare : Form
    {
        public Ricercare()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./File.txt");
            string x = textBox1.Text;
            string y = sr.ReadLine();
            while (y != null)
            {
                string name = y.Split(';')[0];
                if (name == x && y.Split(';')[4] == "True")
                {
                    string n = $"Nome: {y.Split(';')[0]}\nPrezzo: {y.Split(';')[1]}\nIngredienti: {y.Split(';')[2]}\nPortata: {y.Split(';')[3]}";
                    MessageBox.Show(n);
                }
                y = sr.ReadLine();
            }


        }
    }
}
