using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareRistorante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(Password.Text == "")
            {
                MessageBox.Show("Enter Admin Code");
            }
            else if (Password.Text == "KEKKO")
            {
                Staff x = new Staff();
                x.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Cliente_Click(object sender, EventArgs e)
        {
            Ordinare x = new Ordinare();
            this.Visible = false;
            x.ShowDialog();
            this.Visible = true;
        }
    }
}
