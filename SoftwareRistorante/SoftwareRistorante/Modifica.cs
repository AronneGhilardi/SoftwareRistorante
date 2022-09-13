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
    public partial class Modifica : Form
    {
        public Modifica()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./File.txt");
            string x = textBox2.Text;
            string n = null;
            string y = sr.ReadLine();
            while (y != null)
            {
                if (x == y.Split(';')[0])
                {
                    if (checkBox1.Checked == true)
                    {
                        n += textBox3.Text;
                    }
                    else
                    {
                        n += y.Split(';')[0];
                    }
                    n += ";";
                    if (checkBox2.Checked == true)
                    {
                        n += textBox4.Text;
                    }
                    else
                    {
                        n += y.Split(';')[1];
                    }
                    n += ";";
                    if (checkBox3.Checked == true)
                    {
                        n += textBox5.Text;
                    }
                    else
                    {
                        n += y.Split(';')[2];
                    }
                    n += ";";
                    if (checkBox4.Checked == true)
                    {
                        n += textBox5.Text;
                    }
                    else
                    {
                        n += y.Split(';')[3];
                    }
                    n += ";" + y.Split(';')[4];

                }
                y = sr.ReadLine();
            }

            sr.Close();
            StreamReader sr1 = new StreamReader("./File.txt");
            string write = null;
            y = "";
            while (y != null)
            {
                y = sr1.ReadLine();
                if (y != null)
                {
                    string z = y;
                    if (y.Split(';')[0] != textBox2.Text)
                    {
                        write += z;
                        write += "\n";
                    }
                    else
                    {
                        write += n;
                        write += "\n";
                    }
                }
            }
            sr1.Close();
            File.WriteAllText("./File.txt", write);
            this.Close();
        }
    }
}
