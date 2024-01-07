using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACHO01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pb_titulo_cacho_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            frmRegistroJugadores j = new frmRegistroJugadores();
            this.Hide();
            j.Show();
        }

        private void btnReglas_Click(object sender, EventArgs e)
        {
            frmReglas j = new frmReglas();
            this.Hide();
            j.Show();
        }

        private void imgElgame_Click(object sender, EventArgs e)
        {
          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
