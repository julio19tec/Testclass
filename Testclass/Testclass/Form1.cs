using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Videojuegos_Click(object sender, EventArgs e)
        {
            Videojuegos v = new Videojuegos();
            v.Nombre = 2000;
            MessageBox.Show(v.ToString());
        }

        private void ResidentEvil_Click(object sender, EventArgs e)
        {
            ResidentEvil v = new ResidentEvil();
            v.Nombre = 4;
            v.Fabricante = "Capcom Resident Evil";
            MessageBox.Show(v.ToString());

        }

        private void Halo_Click(object sender, EventArgs e)
        {
            Halo v  = new Halo();
            v.Nombre = 1;
            v.Fabricante = "BungieStudios Halo";
            v.Duracion="7:36:00";
            MessageBox.Show(v.ToString());

        }
    }
}
