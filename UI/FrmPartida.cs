using System;
using System.Threading;
using System.Windows.Forms;
using TrucoConTruco;

namespace UI
{

    public partial class FrmPartida : Form
    {
        Sala sala;

        public FrmPartida()
        {
            InitializeComponent();
        }
        public FrmPartida(Sala sala) : this()
        {
            this.sala = sala;
        }

        private void FrmPartidaUno_Load(object sender, EventArgs e)
        {
          
            sala.mensajesRonda += MostrarRondaPorRonda;
            
        }
      

        private void MostrarRondaPorRonda(string texto)
        {
            if (this.rtbJugada.InvokeRequired)
            {
                this.rtbJugada.BeginInvoke((MethodInvoker)delegate ()
                {
                    rtbJugada.AppendText(texto); 
                });

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.sala.partida.cts.Cancel();
            MostrarRondaPorRonda("Partida finalizada");
            MessageBox.Show("Partida finalizada");
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
