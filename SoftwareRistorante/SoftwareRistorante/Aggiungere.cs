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
    public partial class Aggiungere : Form
    {
        public Aggiungere()
        {
            InitializeComponent();
        }

        public void write(string x)
        {
            var oStream = new FileStream("./File.txt", FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(x);
            sw.Close();
        }

        public void salva()
        {
            string x;
            if (textBox3.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox4.Text != "")
            {
                try
                {
                    decimal y = Convert.ToDecimal(textBox2.Text);
                    string sep = ";";
                    x = textBox3.Text + sep + textBox2.Text + sep + textBox4.Text + sep + textBox4.Text + sep + "True";
                    write(x);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("ERRORE! Il prezzo deve essere composto da cifre.");
                }
            }
        }
    }
}
