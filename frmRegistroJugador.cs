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
    public partial class frmRegistroJugadores : Form
    {
        int num_jug;
        int numero_max;

        public frmRegistroJugadores()
        {
            InitializeComponent();
            Estatica.jugadores = new Lista_Jugadores();
            num_jug = 0;
        }

        public bool validarJugadores()
        {
            Nodo_Jugador val = Estatica.jugadores.getCabeza();
            if(val != null)
            {
                do
                {
                    if (val.Nombre == txtNombreJugador.Text)
                    {
                        return true;
                    }
                    val = val.Enlace;
                } while (val != Estatica.jugadores.getCabeza());
            }
            return false;
        }

        public void llenadoLabels(int n)
        {
            switch (n)
            {
                case 1:
                    lblPrimerLugar.Visible = true;
                    lblPname.Text = txtNombreJugador.Text;
                    break;
                case 2:
                    lblSegundoLugar.Visible = true;
                    lblSname.Text = txtNombreJugador.Text;
                    break;
                case 3:
                    lblTercerLugar.Visible = true;
                    lblTname.Text = txtNombreJugador.Text;
                    break;
                case 4:
                    lblCuartoLugar.Visible = true;
                    lblCname.Text = txtNombreJugador.Text;
                    break;
                case 5:
                    lblQuintoLugar.Visible = true;
                    lblQname.Text = txtNombreJugador.Text;
                    break;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(num_jug < numero_max)
            {
                if (txtNombreJugador.Text != "")
                {
                    if (validarJugadores() == false)
                    {
                        num_jug++;
                        llenadoLabels(num_jug);
                        Estatica.jugadores.crear_lista_circular(txtNombreJugador.Text, num_jug);
                        MessageBox.Show("JUGADOR " + num_jug + " REGISTRADO");
                        txtNombreJugador.Text = "";
                    }
                    else MessageBox.Show("EL NOMBRE YA ESTA EN USO");

                }
                else MessageBox.Show("INGRESE EL NOMBRE DEL JUGADOR");
            }
            else
            {
                MessageBox.Show("NUMERO MAXIMO DE JUGADORES ALCANZADO");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRegistroJugadores_Load(object sender, EventArgs e)
        {

        }

        private void btnNumJugadores_Click(object sender, EventArgs e)
        {
            
            if(cbxNumeroDeJugadores.Text != "")
            {
                numero_max = int.Parse(cbxNumeroDeJugadores.Text);
                btnNumJugadores.Visible = false;
                cbxNumeroDeJugadores.Enabled = false;
                gpbRegristro.Visible = true;
                btnSiguiente.Visible = true;

            }
            else
            {
                MessageBox.Show("INGRESE LA CANTIDAD DE JUGADORES");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMain fr1 = new frmMain();
            this.Close();
            fr1.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(numero_max == num_jug)
            {
                frmJuego fr1 = new frmJuego();
                this.Close();
                fr1.Show();
            }
            else{
                MessageBox.Show("TERMINE DE INGRESAR LOS JUGADORES");
            }
        }

        private void gpbRegristro_Enter(object sender, EventArgs e)
        {

        }

        private void lblPrimerLugar_Click(object sender, EventArgs e)
        {

        }
    }
}
