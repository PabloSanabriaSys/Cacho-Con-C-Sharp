using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACHO01
{
    public partial class frmJuego : Form
    {
        Nodo_Jugador jug;
        ListaDados tiroHdCop;
        ListaDados tiroHd;
        bool[] seleccionados;
        int Limite;
        int jugada;
        int numJugMax, numJug;

        public frmJuego()
        {
            InitializeComponent();
            jugada = 0;
            tiroHd = new ListaDados();
            jug = Estatica.jugadores.getCabeza();
            lblNombre.Text ="TURNO DE " + jug.Nombre + ":";
            lblNombre.ForeColor = Color.White;
            seleccionados = new bool[5];
            seleccionados[0]= false;
            seleccionados[1] = false;
            seleccionados[2] = false;
            seleccionados[3] = false;
            seleccionados[4] = false;
            Limite = 10;
            numJugMax = Estatica.jugadores.getUltimo().Numero_jugador * 11;
            numJug = 0;
            limpiarLabels();

        }


        public void limpiarLabels()
        {
            for(int i = 1; i <= 11; i++)
            {
                limpiarPuntaje(i);
            }
        }
        
        private void frmRegistroJugadores_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            imgDado1.Image = DadoImg(4);
            imgDado2.Image = DadoImg(6);
            imgDado3.Image = DadoImg(2);
            imgDado4.Image = DadoImg(1);
            imgDado5.Image = DadoImg(2);

        }
        private System.Drawing.Bitmap DadoImg(int n)
        {
            if (n == 1) return Properties.Resources.dado02;
            if (n == 2) return Properties.Resources.dado01;
            if (n == 3) return Properties.Resources.dado03;
            if (n == 4) return Properties.Resources.dado04;
            if (n == 5) return Properties.Resources.dado05;
            if (n == 6) return Properties.Resources.dado06;

            return null;
        }
        private System.Drawing.Bitmap DadoImgN(int n)
        {
            if (n == 1) return Properties.Resources.dado01ne;
            if (n == 2) return Properties.Resources.dado02ne;
            if (n == 3) return Properties.Resources.dado03ne;
            if (n == 4) return Properties.Resources.dado04ne;
            if (n == 5) return Properties.Resources.dado05ne;
            if (n == 6) return Properties.Resources.dado06ne;

            return null;
        }

        public void lanzar()
        {
            tiroHd = new ListaDados();
            tiroHd.tiroCubilete();
            imgDado1.Image = DadoImg(tiroHd.buscarDado(0).Num);
            imgDado2.Image = DadoImg(tiroHd.buscarDado(1).Num);
            imgDado3.Image = DadoImg(tiroHd.buscarDado(2).Num);
            imgDado4.Image = DadoImg(tiroHd.buscarDado(3).Num);
            imgDado5.Image = DadoImg(tiroHd.buscarDado(4).Num);
        }

        public void copiarTiro()
        {
            tiroHdCop = new ListaDados();
            for(int i = 0; i <5; i++)
            {
                tiroHdCop.crear_lista(i);
            }

            NodoDado con = tiroHd.Cabeza;

            for(NodoDado i = tiroHdCop.Cabeza; i!=null; i = i.Enlace)
            {
                i.Num = con.Num;
                con = con.Enlace;
            }
            tiroHdCop.ordenarDados();
        }

        public void modificarPuntaje(int pos, int puntaje)
        {
            switch (pos)
            {
                case 1:
                    lbl1.Text = puntaje.ToString();
                    break;
                case 2:
                    lbl2.Text = puntaje.ToString();
                    break;
                case 3:
                    lbl3.Text = puntaje.ToString();
                    break;
                case 4:
                    lbl4.Text = puntaje.ToString();
                    break;
                case 5:
                    lbl5.Text = puntaje.ToString();
                    break;
                case 6:
                    lbl6.Text = puntaje.ToString();
                    break;
                case 7:
                    lbl7.Text = puntaje.ToString();
                    break;
                case 8:
                    lbl8.Text = puntaje.ToString();
                    break;
                case 9:
                    lbl9.Text = puntaje.ToString();
                    break;
                case 10:
                    lbl10.Text = puntaje.ToString();
                    break;
                case 11:
                    lbl11.Text = puntaje.ToString();
                    break;
            }
        }

        public void limpiarPuntaje(int pos)
        {
            switch (pos)
            {
                case 1:
                    lbl1.Text = "";
                    break;
                case 2:
                    lbl2.Text = "";
                    break;
                case 3:
                    lbl3.Text = "";
                    break;
                case 4:
                    lbl4.Text = "";
                    break;
                case 5:
                    lbl5.Text = "";
                    break;
                case 6:
                    lbl6.Text = "";
                    break;
                case 7:
                    lbl7.Text = "";
                    break;
                case 8:
                    lbl8.Text = "";
                    break;
                case 9:
                    lbl9.Text = "";
                    break;
                case 10:
                    lbl10.Text = "";
                    break;
                case 11:
                    lbl11.Text = "";
                    break;
            }
        }

        public void MostrarRDB(int pos)
        {
            switch (pos)
            {
                case 1:
                    rdb1.Visible = true;
                    break;
                case 2:
                    rdb2.Visible = true;
                    break;
                case 3:
                    rdb3.Visible = true;
                    break;
                case 4:
                    rdb4.Visible = true;
                    break;
                case 5:
                    rdb5.Visible = true;
                    break;
                case 6:
                    rdb6.Visible = true;
                    break;
                case 7:
                    rdb7.Visible = true;
                    break;
                case 8:
                    rdb8.Visible = true;
                    break;
                case 9:
                    rdb9.Visible = true;
                    break;
                case 10:
                    rdb10.Visible = true;
                    break;
                case 11:
                    rdb10.Visible = true;
                    break;
            }
        }

        public PictureBox imgDado(int pos)
        {
            switch (pos)
            {
                case 1:
                    return imgDado1;
                    break;
                case 2:
                    return imgDado2;
                    break;
                case 3:
                    return imgDado3;
                    break;
                case 4:
                    return imgDado4;
                    break;
                case 5:
                    return imgDado5;
                    break;
            }
            return null;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (tiroHd.Cabeza == null)
            {
                lanzar();
                copiarTiro();
                int puntaje = tiroHdCop.comprobarMano(ref pos);

                if (puntaje != 0)
                {
                    if (jug.Puntaje[pos - 1] == -1)
                    {
                        modificarPuntaje(pos, puntaje);
                        jug.Puntaje[pos - 1] = puntaje;
                        btnLanzar.Visible = false;
                        btnSiguiente.Visible = true;
                        MessageBox.Show("SU JUGADA FUE DE MANO");
                    }
                    else
                    {
                        MessageBox.Show("SU JUGADA FUE DE MANO \n PERO YA TIENE ESA JUGADA");
                    }
                } 
                else lblSeleccioneDados.Text = "SELECCIONE LOS DADOS PARA VOLVER A LANZAR";
            }
            else 
            {
                if (cantSeleccionados() > 0)
                {
                    btnLanzar.Visible = false;
                    btnVoltear.Visible = true;
                    for (int i = 0; i < 5; i++)
                    {
                        if (seleccionados[i] == true)
                        {
                            tiroHd.volveraLanzar(i);
                            seleccionados[i] = false;
                            PictureBox cambiar = imgDado(i + 1);
                            cambiar.Image = DadoImg(tiroHd.buscarDado(i).Num);
                        }
                    }
                    Limite = 2;
                    lblSeleccioneDados.Text = "SELECCIONE 1 DADO O 2 PARA GIRAR";
                }
                else MessageBox.Show("SELECCIONE UNO O MAS DADOS");
            }
        }

        public Boolean Lleno(int pos)
        {
            if (jug.Puntaje[pos] != -1)
            {
                return true;
            }
            else return false;
        }

        private void imgTresenraya_Click(object sender, EventArgs e)
        {

        }

        public void corregirPuntaje(int []v)
        {
            for(int i = 0; i < 11; i++)
            {
                if (v[i] != -1)
                {
                    modificarPuntaje(i + 1, v[i]);  
                }
                else limpiarPuntaje(i+1);
            }
        }

        public void coloresJugadores(int jug)
        {
            switch (jug)
            {
                case 1:
                    lblNombre.ForeColor = Color.White;
                    break;
                case 2:
                    lblNombre.ForeColor = Color.Green;
                    break;
                case 3:
                    lblNombre.ForeColor = Color.Magenta;
                    break;
                case 4:
                    lblNombre.ForeColor = Color.Blue;
                    break;
                case 5:
                    lblNombre.ForeColor = Color.Orange;
                    break;
            }
        }

        public int cantSeleccionados()
        {
            int cont = 0;
            for (int i = 0; i < 5; i++)
            {
                if (seleccionados[i] == true)
                {
                    cont++;
                }
            }
            return cont;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void imgDado1_Click(object sender, EventArgs e)
        {
            
            if (seleccionados[0] == false && Limite > cantSeleccionados())
            {
                seleccionados[0] = true;
                imgDado1.Image = DadoImgN(tiroHd.buscarDado(0).Num);
            }
            else
            {
                seleccionados[0] = false;
                imgDado1.Image = DadoImg(tiroHd.buscarDado(0).Num);
            }
        }

        private void imgDado2_Click(object sender, EventArgs e)
        {
            if (seleccionados[1] == false && Limite > cantSeleccionados())
            {
                seleccionados[1] = true;
                imgDado2.Image = DadoImgN(tiroHd.buscarDado(1).Num);
            }
            else
            {
                seleccionados[1] = false;
                imgDado2.Image = DadoImg(tiroHd.buscarDado(1).Num);
            }
        }

        private void imgDado4_Click(object sender, EventArgs e)
        {
            if (seleccionados[3] == false && Limite > cantSeleccionados())
            {
                seleccionados[3] = true;
                imgDado4.Image = DadoImgN(tiroHd.buscarDado(3).Num);
            }
            else
            {
                seleccionados[3] = false;
                imgDado4.Image = DadoImg(tiroHd.buscarDado(3).Num);
            }
        }

        private void imgDado5_Click(object sender, EventArgs e)
        {
            if (seleccionados[4] == false && Limite > cantSeleccionados())
            {
                seleccionados[4] = true;
                imgDado5.Image = DadoImgN(tiroHd.buscarDado(4).Num);
            }
            else
            {
                seleccionados[4] = false;
                imgDado5.Image = DadoImg(tiroHd.buscarDado(4).Num);
            }
        }

        private void imgDado3_Click(object sender, EventArgs e)
        {
            if (seleccionados[2] == false && Limite > cantSeleccionados())
            {
                seleccionados[2] = true;
                imgDado3.Image = DadoImgN(tiroHd.buscarDado(2).Num);
            }
            else
            {
                seleccionados[2] = false;
                imgDado3.Image = DadoImg(tiroHd.buscarDado(2).Num);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cantSeleccionados() > 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (seleccionados[i] == true)
                    {
                        tiroHd.volteardados(i);
                        seleccionados[i] = false;
                        PictureBox cambiar = imgDado(i + 1);
                        cambiar.Image = DadoImg(tiroHd.buscarDado(i).Num);
                    }
                }
                lblSeleccioneDados.Text = "";
                btnVoltear.Visible = false;
                for (int i = 1; i <= 11; i++)
                {
                    if (jug.Puntaje[i - 1] == -1)
                    {
                        MostrarRDB(i);
                    }
                }
                btnConfirmarJugada.Visible = true;
                tiroHd.ordenarDados();
            }
            else MessageBox.Show("SELECCIONE UN DADO O DOS");
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            jugada = 1;
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            jugada = 2;
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            jugada = 3;
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            jugada = 4;
        }

        private void rdb5_CheckedChanged(object sender, EventArgs e)
        {
            jugada = 5;
        }

        private void rdb6_CheckedChanged(object sender, EventArgs e)
        {
            jugada = 6;
        }

        private void rdb7_CheckedChanged(object sender, EventArgs e)
        {
            jugada = 7;
        }

        private void rdb8_CheckedChanged(object sender, EventArgs e)
        {
            jugada = 8;
        }

        private void rdb9_CheckedChanged(object sender, EventArgs e)
        {
            jugada = 9;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (jug.Puntaje[9] == -1)
            {
                jugada = 10;
            }
            else jugada = 11;
        }

        private void btnConfirmarJugada_Click(object sender, EventArgs e)
        {
            if (Lleno(jugada - 1) == false)
            {
                btnSiguiente.Visible = true;
                int puntos = tiroHd.puntajeJugada(jugada);
                modificarPuntaje(jugada, puntos);
                jug.Puntaje[jugada - 1] = puntos;
                btnConfirmarJugada.Visible = false;
                limpiarRDB();
            }
            else MessageBox.Show("YA TIENE ESA JUGADA");
        }

        private void btnMostrarPuntajes_Click(object sender, EventArgs e)
        {
            frmConsultaPuntaje form = new frmConsultaPuntaje();
            form.Show();
        }

        public void limpiarRDB()
        {
            rdb1.Visible = false;
            rdb2.Visible = false;
            rdb3.Visible = false;
            rdb4.Visible = false;
            rdb5.Visible = false;
            rdb6.Visible = false;
            rdb7.Visible = false;
            rdb8.Visible = false;
            rdb9.Visible = false;
            rdb10.Visible = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (numJug < numJugMax-1)
            {
                numJug++;
                lblSeleccioneDados.Text = "";
                btnSiguiente.Visible = false;
                btnVoltear.Visible = false;
                btnConfirmarJugada.Visible = false;
                btnLanzar.Visible = true;
                jug = jug.Enlace;
                corregirPuntaje(jug.Puntaje);
                coloresJugadores(jug.Numero_jugador);
                lblNombre.Text = "TURNO DE " + jug.Nombre + ":";
                tiroHd = new ListaDados();
                Limite = 10;
                lblSeleccioneDados.Text = "";
                imgDado1.Image = null;
                imgDado2.Image = null;
                imgDado3.Image = null;
                imgDado4.Image = null;
                imgDado5.Image = null;
            }
            else
            {
                frmPuntuaciones fr = new frmPuntuaciones();
                this.Hide();
                fr.Show();
            }
        }
    }
}