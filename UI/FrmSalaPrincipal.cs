using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrucoConTruco;

namespace UI
{



    public partial class FrmSalaPrincipal : Form
    {
        Action<List<Sala>> partidasEnJuego;
        List<Sala> listaDeSalas;
        FrmPartida frmPartidaUno;
        List<CancellationTokenSource> listaDeCancelaciones;



        public FrmSalaPrincipal()
        {
            InitializeComponent();
            listaDeSalas = new List<Sala>();
            listaDeCancelaciones = new List<CancellationTokenSource>(); 
        }

        private void btn_crearNuevaSala_Click(object sender, EventArgs e)
        {
            

           CrearNuevaPartida();

        }


        public void MostrarPartidasEnJuego(List<Sala> listaDePartidas)
        {
            DataTable salas = new DataTable();
            salas.Columns.Add("ID De SALA");
            salas.Columns.Add("Nombre de Sala");
            salas.Columns.Add("Nombre de jugador Uno");
            salas.Columns.Add("Puntos Historico Uno");
            salas.Columns.Add("Nombre de jugador Dos");
            salas.Columns.Add("Puntos Historico Dos");


            foreach (var item in listaDePartidas)
            {
                salas.Rows.Add(item.numeroDeSala,item.nombreDeLaSala,
                  item.partida.jugadorUno.usuario.nombre,item.partida.jugadorUno.usuario.historialDePuntos,
                  item.partida.jugadorDos.usuario.nombre, item.partida.jugadorDos.usuario.historialDePuntos);
            }

           
            if (dtgv_Partidas.InvokeRequired)
            {
                this.BeginInvoke(partidasEnJuego, listaDePartidas);
            }
            else
            {

            dtgv_Partidas.DataSource = salas;
            }


            if (dtgv_Partidas.CurrentRow == null)
            {
                return;
            }

        }

        private void CrearNuevaPartida()
        {
            partidasEnJuego += MostrarPartidasEnJuego;
            Mazo mazo = new Mazo("español");
            mazo = Harcodeo.MazoHarcodeado();
            XmlSerializadora<Mazo>.EscribirArchivoXML(mazo);
           
            CancellationTokenSource ctsPartida = new CancellationTokenSource(); 
            listaDeCancelaciones.Add(ctsPartida);
            Sala salaNueva = new Sala("Jugate un Truco", mazo,ctsPartida);
            salaNueva.CrearPartida(new Jugador(new Usuario("Juan",true)),new Jugador(new Usuario("Nacho",true)));
            listaDeSalas.Add(salaNueva);
            partidasEnJuego.Invoke(listaDeSalas);
        }

        private void dtgv_Partidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPartida;

            try
            {
                int row = e.RowIndex;
                int column = e.ColumnIndex;
                idPartida = int.Parse(dtgv_Partidas.Rows[row].Cells[0].Value.ToString());

                Sala salita = listaDeSalas[idPartida];

                frmPartidaUno = new FrmPartida(salita);
                frmPartidaUno.Text = $"Sala {salita.numeroDeSala}";
                frmPartidaUno.ShowDialog();


            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
 