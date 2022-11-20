using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrucoConTruco;

namespace UI
{
    public partial class FrmNuevoJugador : Form
    {
        public FrmNuevoJugador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {

            Jugador jugador = new Jugador(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
             ConexionABaseDeDatos.GuardarJugadores(jugador);

            this.Close();   

        }
    }
}
