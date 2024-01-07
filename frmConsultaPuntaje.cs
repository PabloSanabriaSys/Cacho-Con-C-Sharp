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
    public partial class frmConsultaPuntaje : Form
    {
        int [] puntajes;
        String[] nombres;

        public frmConsultaPuntaje()
        {
            InitializeComponent();
            puntajes = new int[Estatica.jugadores.getTam()];
            nombres = new String[Estatica.jugadores.getTam()];
            mostrarJugadores();
        }

        public void llenarVectores()
        {
            int i = 0;
            Nodo_Jugador cab = Estatica.jugadores.getCabeza();
            do
            {
                puntajes[i] = cab.puntajeMax();
                nombres[i] = cab.Nombre;
                cab = cab.Enlace;
                i++;
            } while (cab != Estatica.jugadores.getCabeza());
        }

        public void ordenar()
        {
            for(int i = 0; i<Estatica.jugadores.getTam(); i++)
            {
                for(int j = i+1; j<Estatica.jugadores.getTam(); j++)
                {
                    if (puntajes[i] < puntajes[j])
                    {
                        int aux = puntajes[i];
                        String auxs = nombres[i];
                        puntajes[i] = puntajes[j];
                        puntajes[j] = aux;
                        nombres[i] = nombres[j];
                        nombres[j] = auxs;
                    }
                }
            }
        }

        public void mostrarJugadores()
        {
            llenarVectores();
            ordenar();
            for (int i = 0; i < Estatica.jugadores.getTam(); i++)
            {
                habilitarPosiciones(i + 1);
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

        private void habilitarPosiciones(int pos)
        {
            switch (pos)
            {
                case 1:
                    lblPname.Text = nombres[pos-1] + " Puntaje: " + puntajes[pos-1];
                    coloresJugadores(pos);
                    lblPname.Visible = true;
                    lblPrimerLugar.Visible = true;
                    break;
                case 2:
                    lblSname.Text = nombres[pos - 1] + " Puntaje: " + puntajes[pos - 1];
                    coloresJugadores(pos);
                    lblSname.Visible = true;
                    lblSegundoLugar.Visible = true;
                    break;
                case 3:
                    lblTname.Text = nombres[pos - 1] + " Puntaje: " + puntajes[pos - 1];
                    coloresJugadores(pos);
                    lblTname.Visible = true;
                    lblTercerLugar.Visible = true;
                    break;
                case 4:
                    lblCname.Text = nombres[pos - 1] + " Puntaje: " + puntajes[pos - 1];
                    coloresJugadores(pos);
                    lblCname.Visible = true;
                    lblCuartoLugar.Visible = true;
                    break;
                case 5:
                    lblQname.Text = nombres[pos - 1] + " Puntaje: " + puntajes[pos - 1];
                    coloresJugadores(pos);
                    lblQname.Visible = true;
                    lblQuintoLugar.Visible = true;
                    break;
            }
        }

        private void btnTerminarJuego_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaPuntaje_Load(object sender, EventArgs e)
        {

        }
    }
}
