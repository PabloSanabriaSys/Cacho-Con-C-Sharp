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
    public partial class frmPuntuaciones : Form
    {
        public frmPuntuaciones()
        {
            InitializeComponent();
            mostrarJugadores();

        }

        public void mostrarJugadores()
        {
            Estatica.jugadores.ordenar();
            Nodo_Jugador cab = Estatica.jugadores.getCabeza();
            for(int i = 0; i < Estatica.jugadores.getTam(); i++)
            {
                habilitarPosiciiones(i + 1, cab);
                cab = cab.Enlace;
            }
        }

        public void coloresJugadores(int jug)
        {
            switch (jug)
            {
                case 1:
                    lblPname.ForeColor = Color.White;
                    break;
                case 2:
                    lblSname.ForeColor = Color.Green;
                    break;
                case 3:
                    lblTname.ForeColor = Color.Magenta;
                    break;
                case 4:
                    lblCname.ForeColor = Color.Blue;
                    break;
                case 5:
                    lblQname.ForeColor = Color.Orange;
                    break;
            }
        }

        private void habilitarPosiciiones(int pos, Nodo_Jugador jug)
        {
            switch (pos)
            {
                case 1:
                    lblPname.Text = jug.Nombre + " Puntaje: " + jug.puntajeMax();
                    coloresJugadores(pos);
                    lblPname.Visible = true;
                    lblPrimerLugar.Visible = true;
                    break;
                case 2:
                    lblSname.Text = jug.Nombre + " Puntaje: " + jug.puntajeMax();
                    coloresJugadores(pos);
                    lblSname.Visible = true;
                    lblSegundoLugar.Visible = true;
                    break;
                case 3:
                    lblTname.Text = jug.Nombre + " Puntaje: " + jug.puntajeMax();
                    coloresJugadores(pos);
                    lblTname.Visible = true;
                    lblTercerLugar.Visible = true;
                    break;
                case 4:
                    lblCname.Text = jug.Nombre + " Puntaje: " + jug.puntajeMax();
                    coloresJugadores(pos);
                    lblCname.Visible = true;
                    lblCuartoLugar.Visible = true;
                    break;
                case 5:
                    lblQname.Text = jug.Nombre + " Puntaje: " + jug.puntajeMax();
                    coloresJugadores(pos);
                    lblQname.Visible = true;
                    lblQuintoLugar.Visible = true;
                    break;
            }
        }

        private void btnTerminarJuego_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Close();
            frmMain.Show();
        }

        private void pgbCorona_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
