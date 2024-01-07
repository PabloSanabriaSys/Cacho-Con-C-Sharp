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
    public partial class frmReglas : Form
    {
        listaDobleCircularReglas ld;
        NodoReglas aux;
        public frmReglas()
        {
            ld=new listaDobleCircularReglas();
            
            ld.crearLista(1);
            ld.crearLista(2);
            ld.crearLista(3);
            ld.crearLista(4);
            aux = ld.getCabeza();
            InitializeComponent();
            aux.pruebaPablo();
            elegir(1);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMain f=new frmMain();
            this.Hide();
            f.Show();
        }

        private void frmReglas_Load(object sender, EventArgs e)
        {

        }
        private void elegir(int num)
        {
            pbxMano.Visible = false;
            pbxNormal.Visible = false;
            if (num == 1) lblTexto.Text= reg1();
            if(num == 2) lblTexto.Text= reg2();
            if (num == 3) lblTexto.Text= reg3();
            if (num == 4) lblTexto.Text= reg4();
            
        }
        
        private string reg1()
        {
            return
            "INTRODUCCIÓN:\n" +
            "El cacho es un juego muy interesante, porque se pone en práctica\n" +
            "la astucia y la destreza al momento de buscar grupos de números,\n" +
            "este juego necesita de 6 dados, que se lanzan aleatoriamente, en\n" +
            "este caso, los datos estarán representados por 6 números  que\n" +
            "serán generados aleatoriamente por el programa, en este juego to\n" +
            "mamos y sabemos que los dados solo tienen números del 1 al 6, en\n" +
            "el cacho estos números cambian de 'nombre' y tienen un diferente\n" +
            "puntaja por cada unidad,estos nombres y sus puntajes respectivos\n" +
            "son:\n";

        }
        private string reg2()
        {
            pbxMano.Visible = true;
            pbxNormal.Visible = true;
            return "";
        }

        private string reg3()
        {

            return
           "LA PARTIDA:\n" +
           "Cada jugador contará con 2 intentos, contará con un pimer  tiro, del cual tendrá\n" +
           "que escoger primero la base de la jugada, es decir  a por qué tipo de jugada irá,\n" +
           "(Tontos, Trenes, Poker, Full, etc)y seguidammente,  un segundo tiro opcional, si \n" +
           "quiere volver a tirar los dados que seleccione,es decir volver a lanzar solo los\n" +
           "dados que el jugador escoja(podrían ser todos si así lo quiere), despues el juga-\n" +
           "dor deberá voltear el dado  que quiera para concretar su jugada, (esto de voltear\n" +
           "un dado la primera vez es obligatorio), y luego un seundo volteo opcional;el pun-\n" +
           "tage que se va acumulando se irá anotando en el espacio y con el valor que corres-\n" +
           "ponda; el juego termina cuando se dan las siguientes condiciones:\n" + "\n";

        }

        private string reg4()
        {
            return
                       "1. Ya nadie tenga que anotar.\n" +
             "2. Algún jugador haya sacado la jugada 'dormida'\n" +
             "3. Si algún jugador tiene llena la 'panza de oro', es decir sacó Poker, Full \n" +
             "   y Escalera de mano.\n" +
             "4. Si un jugador tiene la grande, llenos todos  los espacios numéricos al má- \n" +
             "   ximo, y mínimo un Poker.";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            elegir(aux.getNum());
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {
            aux = aux.getAnt();
            elegir(aux.getNum());
        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            aux = aux.getSig();
            elegir(aux.getNum());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
