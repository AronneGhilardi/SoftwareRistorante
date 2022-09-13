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
    public partial class Ordinare : Form
    {
        public Ordinare()
        {
            InitializeComponent();
        }

        string[] menu = new string[100];
        string[] ordine = new string[100];
        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./File.txt"); ;
            string y = sr.ReadLine();
            int count = 0;
            while (y != null)
            {
                if (y.Split(';')[4] == "True")
                {
                    menu[count] = $"Portata: {y.Split(';')[0]}\tNome: €{y.Split(';')[1]} \tDescrizione: {y.Split(';')[2]}\tPrezzo: {y.Split(';')[3]}";
                    Menù.Items.Add(menu[count]);
                }
                y = sr.ReadLine();
                count++;
            }
            sr.Close();


            StreamReader sr1 = new StreamReader("./File.txt"); ;
            y = "";
            count = 0;
            while (y != null)
            {
                y = sr1.ReadLine();
                if (y != null)
                {
                    if (y.Split(';')[4] == "True")
                    {
                        ordine[count] = y;
                    }
                    count++;
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = Menù.SelectedItem.ToString();
            Menù.Items.Add(x);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ordine.Items.RemoveAt(Ordine.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] w = new string[Ordine.Items.Count + 1];
            for (int i = 0; i < Ordine.Items.Count; i++)
            {
                string x = Ordine.Items[i].ToString();
                for (int y = 0; y < x.Length; y++)
                {
                    if (x[y] == '€')
                    {
                        for (int z = y; x[z] != ' '; z++)
                        {
                            w[i] += x[z];
                        }
                    }
                }
            }
            decimal[] t = new decimal[Ordine.Items.Count];
            for (int i = 0; i < Ordine.Items.Count; i++)
            {
                w[i] = w[i].Substring(1);
                t[i] = Convert.ToDecimal(w[i]);
            }
            label.Text = "€" + Convert.ToString(t.Sum());
        }
    }
}
