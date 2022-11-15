using System;
using System.Windows.Forms;
using TrucoConTruco;

namespace UI
{

    public partial class FrmPartidaUno : Form
    {
        Action<string> partidasEnJuego;
        Action<string> mensajesRonda;
        Mazo mazo;


        public FrmPartidaUno(Action<string> partidasEnJuego, Mazo mazo)
        {
            InitializeComponent();
            this.partidasEnJuego = partidasEnJuego;
            this.mazo = mazo;
        }

        private void FrmPartidaUno_Load(object sender, EventArgs e)
        {

        }

        public void MostrarRondaPorRonda(string jugada)
        {
            if (this.rtbJugada.InvokeRequired)
            {
                this.BeginInvoke(mensajesRonda,jugada);
            }
            else
            {

                rtbJugada.Text += jugada;
            }
        }

        private void btn_iniciarPartida_Click(object sender, EventArgs e)
        {
            mensajesRonda = MostrarRondaPorRonda;
            
            Sala salaNueva = new Sala("Jugate un Truco", mazo, mensajesRonda);
            salaNueva.CrearPartida();
            btn_iniciarPartida.Enabled = false;
            partidasEnJuego(salaNueva.nombreDeLaSala);
        }
    }
}
