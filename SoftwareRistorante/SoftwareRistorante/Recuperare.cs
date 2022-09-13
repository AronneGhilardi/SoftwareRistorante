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
    public partial class Recuperare : Form
    {
        public Recuperare()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr1 = new StreamReader("./File.txt");
            string write = null;
            string y = "";
            while (y != null)
            {
                y = sr1.ReadLine();
                if (y != null)
                {
                    string z = y;
                    if (y.Split(';')[0] != textBox1.Text)
                    {
                        write += z;
                        write += "\n";
                    }
                    else
                    {
                        string sep = ";";
                        write += y.Split(';')[0] + sep + y.Split(';')[1] + sep + y.Split(';')[2] + sep + y.Split(';')[3] + sep + "True" + "\n";
                    }
                }
            }
            sr1.Close();
            File.WriteAllText("./File.txt", write);
            this.Close();
        }
    }
}
