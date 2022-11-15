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



    public partial class FrmSalaPrincipal : Form
    {
        Action<string> partidasEnJuego;



        public FrmSalaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_crearNuevaSala_Click(object sender, EventArgs e)
        {


            Task.Run(() => CrearNuevoForm());

            partidasEnJuego = MostrarPartidaTerminada;
           
            //FrmPartidaUno frmPartidaUno = new FrmPartidaUno(partidasEnJuego,mazo);
            //frmPartidaUno.ShowDialog();

        }


        public void MostrarPartidaTerminada(string nombrePartida)
        {   
            List<string> partidas = new List<string>();
            dataGridView1.AutoGenerateColumns = true;
            partidas.Add(nombrePartida);    
            if (this.dataGridView1.InvokeRequired)
            {
                this.BeginInvoke(partidasEnJuego, partidas);
            }
            else
            {

                dataGridView1.DataSource = partidas;
            }




        }

        private void CrearNuevoForm()
        {
            partidasEnJuego = MostrarPartidaTerminada;
            Mazo mazo = new Mazo("español");
            mazo = Harcodeo.MazoHarcodeado();
            XmlSerializadora<Mazo>.EscribirArchivoXML(mazo);

            new FrmPartidaUno(partidasEnJuego, mazo).ShowDialog();
        }



    }
}
 